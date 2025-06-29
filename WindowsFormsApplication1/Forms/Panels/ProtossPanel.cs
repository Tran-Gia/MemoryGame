using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WindowsFormsApplication1.Constants;
using WindowsFormsApplication1.Enums;
using WindowsFormsApplication1.Functions.Controllers;
using WindowsFormsApplication1.Functions.GlobalFunctions;
using WindowsFormsApplication1.Functions.ProgressBarFunctions;
using WindowsFormsApplication1.Functions.UserSettings;

namespace WindowsFormsApplication1
{
    public partial class ProtossPanel : Form
    {
        bool ExitGame = true;
        int startingRoundEnergy = 0;
        readonly ToolTip EnergyTooltip;
        private readonly MediaPlayer _bgmPlayer;
        private CardController _controller;

        public ProtossPanel()
        {
            Shown += ProtossPanel_Shown;
            FormClosed += ProtossPanel_FormClosed;
            InitializeComponent();
            _bgmPlayer = new MediaPlayer();

            EnergyTooltip = new ToolTip
            {
                ShowAlways = true
            };
            EnergyTooltip.SetToolTip(EnergyProBar, EnergyProBar.Value + " / 1000");

            BackgroundImage = Backgrounds.ProtossBackground;
            BackgroundImageLayout = ImageLayout.Stretch; //TODO: update this

            UserSettingHelper.SetResolution(this);
        }

        private void ProtossPanel_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            PanelTimer.Interval = DefaultValues.TimerInterval;

            _controller = new CardController(this, new Size(100, 100),null, 14);
            _controller.CreateCards();

            RemainingTimeProBar.SetProgressNoAnimation(RemainingTimeProBar.Maximum);
            BGMStart();
        }

        #region Game Systems
        public void DisplayScoreCombo()
        {
            var score = StringHelper.PrependZero
            (
                _controller.GetScore(),
                DefaultValues.ScoreDigits
            );

            var combo = StringHelper.PrependZero
            (
                _controller.GetCombo(),
                DefaultValues.ComboDigits
            );

            ScoreLabel.Text = $"Score: {score}";
            Combolbl.Text = $"{combo}X";
        }

        public void UpdateEnergyProgressBar(int value)
        {
            EnergyProBar.Value = 
                EnergyProBar.Value + value > EnergyProBar.Maximum ?
                EnergyProBar.Maximum :
                EnergyProBar.Value + value;

            EnergyTooltip.SetToolTip(EnergyProBar, EnergyProBar.Value + " / 1000");
        }

        public void RoundCleanup()
        {
            SetGameTimerStatus(false);
            AbilitiesBtn.Enabled = false;
            GameStartBtn.Text = "START";
            GameStartBtn.Enabled = true;

            foreach (var f in Application.OpenForms.OfType<AbilitiesDialog>().ToList())
            {
                f.Close();
            }
        }

        public void LevelAdvance()
        {
            startingRoundEnergy = EnergyProBar.Value;
            RemainingTimeProBar.Value = 0;
            TimeLabel.Text = "00:00";

            _controller.CreateCards();
            ActiveForm.Text = "Level " + _controller.Level;
        }

        public void GameOver()
        {
            GameStartBtn.Text = "RESTART";
            AbilitiesBtn.Enabled = false;
            foreach (var f in Application.OpenForms.OfType<AbilitiesDialog>().ToList())
            {
                f.Close();
            }
        }
        public void SetGameTimerStatus(bool isStarted)
        {
            if (isStarted)
            {
                PanelTimer.Start();
                return;
            }

            PanelTimer.Stop();
        }

        public void SetTimerProBarMaximum(int value)
        {
            RemainingTimeProBar.Value =
                RemainingTimeProBar.Maximum =
                value * 10;
        }

        public void SetTimerToZero()
        {
            RemainingTimeProBar.Value = 0;
            TimeLabel.Text = "00:00";
        }
        #endregion

        #region Sound Setting
        public void BGMStart()
        {
            if (UserSetting.MusicEnabled)
            {
                if(_bgmPlayer.Source == null)
                    _bgmPlayer.Open(AudioUri.ProtossBGM);
                _bgmPlayer.Play();
                _bgmPlayer.MediaEnded += BGMPlayer_MediaEnded;
            }
        }
        public void BGMStop()
        {
            _bgmPlayer.Pause();
        }
        private void BGMPlayer_MediaEnded(object sender, EventArgs e)
        {
            _bgmPlayer.Position = TimeSpan.Zero;
            BGMStart();
        }
        #endregion

        private void AlertSoundNotEnoughEnergy()
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(
                    (Stream)Properties.Resources.ResourceManager.GetObject(
                        "Protoss_NotEnoughEnergy"));
                sp.Play();
            }
            catch
            {
                Console.WriteLine("Sound file Energy Alert not found");
            }
        }

        private void PanelTimer_Tick(object sender, EventArgs e)
        {
            if (_controller.GameIsPaused || !_controller.GameIsInProgress)
                return;

            EnergyProBar.PerformStep();
            EnergyTooltip.SetToolTip(EnergyProBar, EnergyProBar.Value + " / 1000");

            RemainingTimeProBar.PerformStep();

            var remainingTime = _controller.GetRemainingTime();
            var minutesLabel = remainingTime.Minutes < 10 ?
                $"0{remainingTime.Minutes}" :
                remainingTime.Minutes.ToString();

            var secondsRoundup = Math.Ceiling(
                remainingTime.Seconds + (remainingTime.Milliseconds / 1000.0));
            var secondsLabel = secondsRoundup < 10 ?
                $"0{secondsRoundup}" :
                secondsRoundup.ToString();

            TimeLabel.Text = $"{minutesLabel}:{secondsLabel}";

            if(remainingTime.TotalSeconds <= 0)
                PanelTimer.Stop();
        }

        #region Game Buttons
        private async void GameStartBtn_Click(object sender, EventArgs e)
        {
            if (GameStartBtn.Text == "START")
            {
                SetGameTimerStatus(true);
                GameStartBtn.Enabled = false;
                _controller.DisplayCards();
                SetTimerProBarMaximum(_controller.LevelTime);

                await AwaitWithConditions
                    .AdditionalTimeoutWhileTrue(() =>
                    _controller.GameIsPaused, 500);

                await _controller.RoundStart();
                GameStartBtn.Text = "RESTART";
                AbilitiesBtn.Enabled = true;
                GameStartBtn.Enabled = true;
                return;
            }

            RemainingTimeProBar.Value = RemainingTimeProBar.Maximum;
            EnergyProBar.Value = startingRoundEnergy;
            EnergyTooltip.SetToolTip(EnergyProBar, EnergyProBar.Value + " / 1000");
            AbilitiesBtn.Enabled = false;
            GameStartBtn.Text = "START";

            _controller.RoundRestart();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            _controller.PauseGame();
            SetGameTimerStatus(false);

            var menuIsDismissed = false;
            //Music (1) - Sound (2) - Exit To Menu (3) - Exit Game (4) - Cancel (5)
            int result = GameMenu.MenuRequest();
            switch (result)
            {
                case 1:
                    if (UserSetting.MusicEnabled)
                    {
                        BGMStart();
                        break;
                    }

                    BGMStop();
                    break;

                case 2:
                    //do nothin
                    break;

                case 3:
                    ExitGame = false;
                    Close();
                    FirstPanel FP = new FirstPanel();
                    FP.Show();
                    return;

                case 4:
                    Application.Exit();
                    return;

                default:
                    menuIsDismissed = true;
                    break;
            }

            if (menuIsDismissed)
            {
                UserSettingHelper.SetResolution(this);
                _controller.ResumeGame();
                SetGameTimerStatus(true);

                return;
            }

            MenuBtn_Click(sender, e);
        }

        private async void PowerUpBtn_Click(object sender, EventArgs e)
        {
            var result = AbilitiesDialog.Show(this, AbilitiesBtn.Location.X,AbilitiesBtn.Width, AbilitiesBtn.Location.Y, AbilitiesBtn.Height);

            if (!_controller.GameIsInProgress || _controller.GameOver)
                return;

            switch (result)
            {
                case Ability.SolarPanels:
                    if(EnergyProBar.Value >= 500)
                    {
                        EnergyProBar.Value -= 500;
                        _controller.RevealCards(1.5);
                    }
                    else
                    {
                        AlertSoundNotEnoughEnergy();
                    }
                    break;
                case Ability.InstantPair:
                    if (EnergyProBar.Value >= 200)
                    {
                        EnergyProBar.Value -= 200;
                        await _controller.InstantPair();
                    }
                    else
                    {
                        AlertSoundNotEnoughEnergy();
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void ProtossPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            _bgmPlayer.Stop();
            _controller = null;

            if (ExitGame)
            {
                MessageBox.Show("Thank you for playing this game!", "Exit Game");
                Application.Exit();
            }
        }
    }
}