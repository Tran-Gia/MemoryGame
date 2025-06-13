using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Enums;
using WindowsFormsApplication1.Forms.Buttons;
using WindowsFormsApplication1.Functions.CardFunctions;
using WindowsFormsApplication1.Functions.Units;
using static System.Windows.Forms.Control;

namespace WindowsFormsApplication1.Functions.Controllers
{
    public class CardController
    {
        private readonly ControlCollection _controls;
        private readonly ProtossPanel _form;
        private readonly int MAX_TYPE = 7;
        private readonly Timer _levelTimer = new Timer();

        private int _amount = 0;
        private Size _cardSize = new Size(150,150);
        private Image _defaultImage = (Image)Properties.Resources.ResourceManager.GetObject("Protoss_Image_Default");
        private MatchingCard[] _cards;
        private MatchingCard _firstSelectedCard;
        private MatchingCard _secondSelectedCard;
        private int _score = 0;
        private int _combo = 1;
        private int _baseScore = 5;
        private int _totalTypes = 5;
        private bool _gameStarted = false;
        private double _remainingTime;
        public int Level { get; set; } = 1;
        public int LevelTime { get; set; } = 20;

        public CardController(ControlCollection controls, ProtossPanel form, Size? cardSize, Image defaultImage = null, int amount = 0)
        {
            _amount = amount;
            _cardSize = cardSize != null ? (Size)cardSize : _cardSize;
            _defaultImage = defaultImage ?? _defaultImage;
            _controls = controls;
            _form = form;
            _levelTimer.Interval = 100;
            _levelTimer.Tick += LevelTimer_Tick;
        }

        public CardController()
        {
        }

        public CardController SetAmount(int amount)
        {
            _amount = amount;
            return this;
        }

        public CardController SetCardSize(Size cardSize) 
        {
            _cardSize = cardSize;
            return this;
        }

        public CardController SetDefaultImage(Image image)
        {
            _defaultImage = image;
            return this;
        }

        public CardController SetGameState(bool gameStarted)
        {
            _gameStarted = gameStarted;

            if(_cards != null)
            {
                foreach (var card in _cards)
                {
                    card.Enabled = gameStarted;
                }
            }

            _levelTimer.Enabled = gameStarted;

            return this;
        }

        public TimeSpan GetRemainingTime()
        {
            return TimeSpan.FromSeconds(_remainingTime);
        }   

        public int GetScore()
        {
            return _score;
        }

        public int GetCombo()
        {
            return _combo;
        }

        public void CreateCards()
        {
            _firstSelectedCard = _secondSelectedCard = null;

            _cards = _cards.CreateCards(_cardSize, _defaultImage, _amount);
            foreach (var card in _cards)
            {
                card.Click += SelectOneCard;
            }

            _cards.SetCardsLocation(Level);
            _cards.SetUnitTypeForCards(_totalTypes);
        }

        public void DisplayCards()
        {
            _controls.AddRange(_cards);
            foreach (var card in _cards)
            {
                card.Visible = true;
                card.Enabled = true;
            }
        }

        public void RevealCards()
        {
            foreach (var card in _cards)
            {
                if (card.State == MatchingState.None)
                {
                    card.Image = (Image)Properties.Resources.ResourceManager.GetObject(card.UnitType.ImagePath);
                    card.State = MatchingState.Revealed;
                }
            }
        }

        public void HideCards()
        {
            foreach(var card in _cards)
            {
                if (card.State == MatchingState.Revealed)
                {
                    card.Image = _defaultImage;
                    card.State = MatchingState.None;
                }
            }
        }

        public async Task RoundStart()
        {
            RevealCards();

            await Task.Delay(2000);

            HideCards();
            _remainingTime = LevelTime;

            await Task.Delay(100);

            SetGameState(true);
            _levelTimer.Start();
        }

        public async Task InstantPair()
        {
            while(_firstSelectedCard != null && _secondSelectedCard != null)
            {
                await Task.Delay(10);
            }

            if(_firstSelectedCard != null)
            {
                var nextCard = _cards.FirstOrDefault(card =>
                    card.UnitType == _firstSelectedCard.UnitType &&
                    card != _firstSelectedCard
                ); //doesn't pierce Revealed & Blocked
                SelectOneCard(nextCard, new EventArgs());
                return;
            }

            var randomIndex = new Random().Next(_cards.Length - 1);
            var firstCard = _cards.ElementAtOrDefault(randomIndex);
            var secondCard = _cards.FirstOrDefault(card =>
                card.UnitType == firstCard.UnitType &&
                card != firstCard
            );

            SelectOneCard(firstCard, new EventArgs());
            await Task.Delay(50);
            SelectOneCard(secondCard, new EventArgs());
        }

        private async void SelectOneCard(object sender, EventArgs e)
        {
            if (_secondSelectedCard != null || !_gameStarted) return;

            var selectedCard = (MatchingCard)sender;

            if (selectedCard == null ||
                selectedCard.State != MatchingState.None ||
                selectedCard == _firstSelectedCard) 
                return;

            if (_secondSelectedCard == null && _firstSelectedCard != null)
            {
                _secondSelectedCard = selectedCard;
            }
            else
            {
                _firstSelectedCard = selectedCard;
            }

            CardControllerFunctions.SelectOneCard(selectedCard);

            if (_secondSelectedCard == null) return;

            var isPair = 
                await CardControllerFunctions.CheckPairAsync
                (
                    _firstSelectedCard,
                    _secondSelectedCard,
                    _defaultImage,
                    true
                );

            if (!isPair)
            {
                _combo = 1;
                if (_score >= 12)
                    _score -= 2;
                _form.DisplayScoreCombo(_score, _combo);

                _firstSelectedCard = _secondSelectedCard = null;
                return;
            }

            _score += _firstSelectedCard.UnitType.Score + _baseScore * _combo;
            _combo++;

            _controls.Remove(_firstSelectedCard);
            _firstSelectedCard.Dispose();
            _controls.Remove(_secondSelectedCard);
            _secondSelectedCard.Dispose();
            _form.DisplayScoreCombo(_score, _combo);

            //manaProgressBar.Step = 10 + 3 * Combo;
            //manaProgressBar.PerformStep();
            //toolTip1.SetToolTip(manaProgressBar, manaProgressBar.Value + " / 1000");

            _firstSelectedCard = _secondSelectedCard = null;
            _cards = _cards
                .Where(card => _controls.Contains(card))
                .ToArray();

            if(_cards.Length == 0)
            {
                RoundEnd(true);
            }
        }

        private void RoundEnd(bool isWon)
        {
            _form.DisplayScoreCombo(_score, _combo);
            SetGameState(false);

            if (isWon)
            {
                RoundCleanup();
                return;
            }

            MessageBox.Show("Aiur has fallen to the Zergs.\nIt will never be restored again.\nFinal Score: " + _score, "Mission Failed!",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            _form.GameOver();
        }

        private void RoundCleanup()
        {
            _form.RoundCleanup();
            //    //low score conversion at low stage, but increase every 2 , 4 , 10 levels.
            //    //At lv20: score += time *(0.5 + 2.5 + 2.5 + 2 ),by then max time = 40 -> max bonus score = 300.
            //    //Max score:     60 - 86.25 - 82.5 - 157.5 - 150 - 166.25 - 157.5 - 212.5
            //    //Time:         120 - 115   - 110  - 105   - 100 -   95   -  90   -  85
            //    //Conversion:   0.5 - 0.75  - 0.75 - 1.5   - 1.5 -  1.75  - 1.75  - 2.5
            var timeSpent = LevelTime - (int)_remainingTime;
            int bonusScore = (int)(_remainingTime / 2 + _remainingTime / 4 * (Level / 2) +
                _remainingTime / 2 * (Level / 4) + _remainingTime * (Level / 10));
            _score += bonusScore;
            _form.DisplayScoreCombo(_score, 1);

            if (Level < 40)
                Level++;

            if (Level % 4 == 0)
                _amount += 2;

            if (Level % 3 == 0)
                _baseScore += 2;

            if (_totalTypes <= MAX_TYPE)
                _totalTypes++;

            if (LevelTime > 45)
                LevelTime -= 5;

            var unitDictionary = UnitDictionary.GetInstance();
            var nextUnit = unitDictionary.GetUnit(_totalTypes-1);
            var advance = NextLevelRevealDialog
                .NextLevelDetails(_score, timeSpent, bonusScore, (int) _remainingTime, _baseScore, _amount, nextUnit.Name,
                    (Image)Properties.Resources.ResourceManager.GetObject(nextUnit.ImagePath)
                );
            if (advance)
                _form.LevelAdvance();
            else
                MessageBox.Show("Final Score: " + _score);
        }

        private void LevelTimer_Tick(object sender, EventArgs e)
        {
            if (_gameStarted)
            {
                _remainingTime -= 0.1;
                //prevents Race Condition: in the middle of pairing last correct cards but timer runs out first
                if (_remainingTime <= 0 && _secondSelectedCard == null)
                {
                    RoundEnd(false);
                }
            }
        }
    }
}
