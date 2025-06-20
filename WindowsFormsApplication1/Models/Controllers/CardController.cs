using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Constants;
using WindowsFormsApplication1.Enums;
using WindowsFormsApplication1.Forms.Buttons;
using WindowsFormsApplication1.Functions.CardFunctions;
using WindowsFormsApplication1.Functions.GlobalFunctions;
using WindowsFormsApplication1.Functions.Units;
using static System.Windows.Forms.Control;

namespace WindowsFormsApplication1.Functions.Controllers
{
    public class CardController
    {
        private const int MAX_TYPE = 7;
        private const int TIMER_INTERVAL = DefaultValues.TimerInterval;
        private const double INFINITE_DURATION = 1000;

        private readonly ControlCollection _controls;
        private readonly ProtossPanel _form;
        private readonly Timer _controllerTimer = new Timer();

        private int _amount = 0;
        private Size _cardSize = new Size(150,150);
        private Image _defaultImage = (Image)Properties.Resources.ResourceManager.GetObject("Protoss_Image_Default");
        private MatchingCard[] _cards;
        private MatchingCard _firstSelectedCard;
        private MatchingCard _secondSelectedCard;
        private int _score = 0;
        private int _combo = 0;
        private int _baseScore = 5;
        private int _totalTypes = 5;
        private double _remainingTime;

        public bool GameIsInProgress { get; private set; } = false;
        public bool GameIsPaused { get; private set; } = false;
        public bool GameOver { get; private set; } = false;
        public int Level { get; set; } = 0;
        public int LevelTime { get; set; } = 20;

        public CardController(ProtossPanel form, Size? cardSize, Image defaultImage = null, int amount = 0)
        {
            _amount = amount;
            _cardSize = cardSize != null ? (Size)cardSize : _cardSize;
            _defaultImage = defaultImage ?? _defaultImage;
            _controls = form.Controls;
            _form = form;
            _controllerTimer.Interval = TIMER_INTERVAL;
            _controllerTimer.Tick += ControllerTimer_Tick;
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

        public CardController PauseGame()
        {
            if (GameOver)
                return this;

            HideCards();
            GameIsPaused = true;

            return this;
        }

        public CardController ResumeGame()
        {
            if (_cards == null || _cards.Length == 0 || GameOver)
                return this;

            foreach (var card in _cards)
            {
                card.Enabled = true;
                if(card.State == MatchingState.Revealed)
                {
                    card.Image = (Image)Properties.Resources.ResourceManager.GetObject(card.UnitType.ImagePath);
                }
            }
            GameIsPaused = false;

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
            GameIsPaused = false;

            _controls.AddRange(_cards);
            foreach (var card in _cards)
            {
                card.Visible = true;
                card.Enabled = true;
            }
        }

        public void RevealCards(double duration = INFINITE_DURATION, bool forcedReveal = false)
        {
            foreach (var card in _cards)
            {
                if (card.State == MatchingState.None || forcedReveal)
                {
                    card.Image = (Image)Properties.Resources.ResourceManager.GetObject(card.UnitType.ImagePath);
                    card.State = MatchingState.Revealed;
                    card.StateDuration = duration;
                }
            }
        }

        public void HideCards()
        {
            foreach(var card in _cards)
            {
                if( card.State != MatchingState.Selected)
                {
                    card.Image = _defaultImage;
                }
                card.Enabled = false;
            }
        }

        public async Task RoundStart()
        {
            _controllerTimer.Start();
            RevealCards(2);

            await AwaitWithConditions.
                AdditionalTimeoutWhileTrue(() => 
                GameIsPaused, 2000, true);
            _remainingTime = LevelTime;

            await Task.Delay(100);

            GameIsInProgress = true;
        }

        public void RoundRestart()
        {
            _combo = 0;
            _score /= 2;

            GameIsInProgress = false;
            GameIsPaused = false;
            GameOver = false;
            CreateCards();
        }

        public async Task InstantPair()
        {
            await AwaitWithConditions.UntilFulfilled(() => 
                _secondSelectedCard == null);

            var selectedCards = CardControllerFunctions
                .GetInstantPair(_cards, _firstSelectedCard);

            if (_firstSelectedCard == null)
            {
                SelectOneCard(selectedCards.Item1, new EventArgs());
                await Task.Delay(50);
            }

            SelectOneCard(selectedCards.Item2, new EventArgs());
        }

        private async void SelectOneCard(object sender, EventArgs e)
        {
            if (_secondSelectedCard != null ||
                !GameIsInProgress ||
                GameIsPaused) 
                return;

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
                _combo = 0;
                if (_score >= 12)
                    _score -= 2;
                _form.DisplayScoreCombo();

                _firstSelectedCard = _secondSelectedCard = null;
                return;
            }

            _score += _firstSelectedCard.UnitType.Score + _baseScore * _combo;
            _combo++;
            _form.UpdateManaProgressBar((int)_firstSelectedCard.UnitType.ManaGain);
            _form.DisplayScoreCombo();

            _controls.Remove(_firstSelectedCard);
            _firstSelectedCard.Dispose();
            _controls.Remove(_secondSelectedCard);
            _secondSelectedCard.Dispose();


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
            GameIsInProgress = false;

            if (isWon)
            {
                RoundCleanup();
                return;
            }

            GameOver = true;
            foreach (var card in _cards)
            {
                card.Enabled = false;
            }
            RevealCards(INFINITE_DURATION, true);

            MessageBox.Show
            (
                "Aiur has fallen to the Zergs." +
                "\nIt will never be restored again." +
                "\nFinal Score: " + _score,
                "Mission Failed!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1
            );

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
            int bonusScore = (int)(_remainingTime / 2 + 
                _remainingTime / 4 * (Level / 2) +
                _remainingTime / 2 * (Level / 4) + 
                _remainingTime * (Level / 10));
            _score += bonusScore;

            _combo = 0;
            _form.DisplayScoreCombo();

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
            var advance = NextLevelRevealDialog.NextLevelDetails
            (
                _form,
                _score,
                timeSpent,
                bonusScore,
                (int) _remainingTime,
                _baseScore,
                _amount,
                nextUnit.Name,
                (Image)Properties.Resources.ResourceManager.GetObject(nextUnit.ImagePath)
            );

            if (advance)
            {
                _form.LevelAdvance();
                return;
            }

            GameOver = true;
            MessageBox.Show("Final Score: " + _score);
        }

        private void ControllerTimer_Tick(object sender, EventArgs e)
        {
            if (GameIsPaused)
                return;

            if (GameIsInProgress)
            {
                _remainingTime -= (double)TIMER_INTERVAL / 1000;
                //prevents Race Condition: pairing last correct cards but timer runs out first
                if (_remainingTime <= 0 && _secondSelectedCard == null)
                {
                    RoundEnd(false);
                    return;
                }
            }

            if(_cards == null || _cards.Length == 0)
                return; 

            foreach (var card in _cards)
            {
                if (card.StateDuration > 0 &&
                    card.StateDuration < INFINITE_DURATION)
                    card.StateDuration -= (double)TIMER_INTERVAL / 1000;

                if (card.StateDuration <= 0 &&
                    card.State != MatchingState.None &&
                    card.State != MatchingState.Selected)
                {
                    card.Image = _defaultImage;
                    card.State = MatchingState.None;
                    card.StateDuration = 0;
                }
            }
        }
    }
}
