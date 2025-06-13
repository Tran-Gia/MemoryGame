using System;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Enums;
using WindowsFormsApplication1.Forms.Buttons;
using WindowsFormsApplication1.Functions.MatchingButtonFunctions;
using WindowsFormsApplication1.Functions.Units;
using static System.Windows.Forms.Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApplication1.Functions.Controllers
{
    public class MatchingButtonController
    {
        private readonly ControlCollection _controls;
        private readonly ProtossPanel _form;
        private readonly int MAX_TYPE = 7;
        private readonly Timer _levelTimer = new Timer();

        private int _amount = 0;
        private Size _buttonSize = new Size(150,150);
        private Image _defaultImage = (Image)Properties.Resources.ResourceManager.GetObject("Protoss_Image_Default");
        private MatchingButton[] _buttons;
        private MatchingButton _firstSelectedButton;
        private MatchingButton _secondSelectedButton;
        private int _score = 0;
        private int _combo = 1;
        private int _baseScore = 5;
        private int _totalTypes = 5;
        private bool _gameStarted = false;
        private double _remainingTime;
        public int Level { get; set; } = 1;
        public int LevelTime { get; set; } = 20;

        public MatchingButtonController(ControlCollection controls, ProtossPanel form, Size? buttonSize, Image defaultImage = null, int amount = 0)
        {
            _amount = amount;
            _buttonSize = buttonSize != null ? (Size)buttonSize : _buttonSize;
            _defaultImage = defaultImage ?? _defaultImage;
            _controls = controls;
            _form = form;
            _levelTimer.Interval = 100;
            _levelTimer.Tick += LevelTimer_Tick;
        }

        public MatchingButtonController()
        {
        }

        public MatchingButtonController SetAmount(int amount)
        {
            _amount = amount;
            return this;
        }

        public MatchingButtonController SetButtonSize(Size buttonSize) 
        {
            _buttonSize = buttonSize;
            return this;
        }

        public MatchingButtonController SetDefaultImage(Image image)
        {
            _defaultImage = image;
            return this;
        }

        public MatchingButtonController SetGameState(bool gameStarted)
        {
            _gameStarted = gameStarted;

            if(_buttons != null)
            {
                foreach (var button in _buttons)
                {
                    button.Enabled = gameStarted;
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

        public void CreateButtons()
        {
            _firstSelectedButton = _secondSelectedButton = null;

            _buttons = _buttons.CreateButtons(_buttonSize, _defaultImage, _amount);
            foreach (var button in _buttons)
            {
                button.Click += SelectOneButton;
            }

            _buttons.SetButtonsLocation(Level);
            _buttons.SetUnitTypeForButtons(_totalTypes);
        }

        public void DisplayButtons()
        {
            _controls.AddRange(_buttons);
            foreach (var button in _buttons)
            {
                button.Visible = true;
                button.Enabled = true;
            }
        }

        public void RevealButtons()
        {
            foreach (var button in _buttons)
            {
                if (button.State == MatchingState.None)
                {
                    button.Image = (Image)Properties.Resources.ResourceManager.GetObject(button.UnitType.ImagePath);
                    button.State = MatchingState.Revealed;
                }
            }
        }

        public void HideButtons()
        {
            foreach(var button in _buttons)
            {
                if (button.State == MatchingState.Revealed)
                {
                    button.Image = _defaultImage;
                    button.State = MatchingState.None;
                }
            }
        }

        public async Task RoundStart()
        {
            RevealButtons();

            await Task.Delay(2000);

            HideButtons();
            _remainingTime = LevelTime;

            await Task.Delay(100);

            SetGameState(true);
            _levelTimer.Start();
        }

        public async Task InstantPair()
        {
            while(_firstSelectedButton != null && _secondSelectedButton != null)
            {
                await Task.Delay(10);
            }

            if(_firstSelectedButton != null)
            {
                var nextButton = _buttons.FirstOrDefault(button =>
                    button.UnitType == _firstSelectedButton.UnitType &&
                    button != _firstSelectedButton
                ); //doesn't pierce Revealed & Blocked
                SelectOneButton(nextButton, new EventArgs());
                return;
            }

            var randomIndex = new Random().Next(_buttons.Length - 1);
            var firstButton = _buttons.ElementAtOrDefault(randomIndex);
            var secondButton = _buttons.FirstOrDefault(button =>
                button.UnitType == firstButton.UnitType &&
                button != firstButton
            );

            SelectOneButton(firstButton, new EventArgs());
            await Task.Delay(50);
            SelectOneButton(secondButton, new EventArgs());
        }

        private async void SelectOneButton(object sender, EventArgs e)
        {
            if (_secondSelectedButton != null || !_gameStarted) return;

            var selectedButton = (MatchingButton)sender;

            if (selectedButton == null ||
                selectedButton.State != MatchingState.None ||
                selectedButton == _firstSelectedButton) 
                return;

            if (_secondSelectedButton == null && _firstSelectedButton != null)
            {
                _secondSelectedButton = selectedButton;
            }
            else
            {
                _firstSelectedButton = selectedButton;
            }

            MatchingButtonControllerFunctions.SelectOneButton(selectedButton);

            if (_secondSelectedButton == null) return;

            var isPair = 
                await MatchingButtonControllerFunctions.CheckPairAsync
                (
                    _firstSelectedButton,
                    _secondSelectedButton,
                    _defaultImage,
                    true
                );

            if (!isPair)
            {
                _combo = 1;
                if (_score >= 12)
                    _score -= 2;
                _form.DisplayScoreCombo(_score, _combo);

                _firstSelectedButton = _secondSelectedButton = null;
                return;
            }

            _score += _firstSelectedButton.UnitType.Score + _baseScore * _combo;
            _combo++;

            _controls.Remove(_firstSelectedButton);
            _firstSelectedButton.Dispose();
            _controls.Remove(_secondSelectedButton);
            _secondSelectedButton.Dispose();
            _form.DisplayScoreCombo(_score, _combo);

            //manaProgressBar.Step = 10 + 3 * Combo;
            //manaProgressBar.PerformStep();
            //toolTip1.SetToolTip(manaProgressBar, manaProgressBar.Value + " / 1000");

            _firstSelectedButton = _secondSelectedButton = null;
            _buttons = _buttons
                .Where(button => _controls.Contains(button))
                .ToArray();

            if(_buttons.Length == 0)
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
            int advance = NextLevelRevealDialog.NextLevelDetails(_score, timeSpent, bonusScore, (int) _remainingTime, _baseScore, _amount, nextUnit.Name, (Image)Properties.Resources.ResourceManager.GetObject(nextUnit.ImagePath));
            if (advance == 1)
                _form.LevelAdvance();
            else
                MessageBox.Show("Final Score: " + _score);
        }

        private void LevelTimer_Tick(object sender, EventArgs e)
        {
            if (_gameStarted)
            {
                _remainingTime -= 0.1;
                //prevents Race Condition: in the middle of pairing last correct buttons but timer runs out first
                if (_remainingTime <= 0 && _secondSelectedButton == null)
                {
                    RoundEnd(false);
                }
            }
        }
    }
}
