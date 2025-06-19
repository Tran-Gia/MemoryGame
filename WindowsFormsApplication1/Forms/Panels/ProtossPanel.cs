using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WindowsFormsApplication1.Enums;
using WindowsFormsApplication1.Functions.Controllers;
using WindowsFormsApplication1.Functions.UserSettings;

namespace WindowsFormsApplication1
{
    //BGM is shitty with Uri, check for solution
    public partial class ProtossPanel : Form
    {
        #region properties
        bool MusicPlaying = false;
        bool ExitGame = true;
        int preMana = 0;
        readonly ToolTip toolTip1;
        readonly MediaPlayer BGMPlayer;
        private CardController _controller;
        #endregion
        public ProtossPanel()
        {
            Shown += ProtossPanel_Shown;
            FormClosed += ProtossPanel_FormClosed;
            InitializeComponent();
            BGMPlayer = new MediaPlayer();
            PowerUpBtn.Enabled = false;
            toolTip1 = new ToolTip
            {
                ShowAlways = true
            };
            toolTip1.SetToolTip(manaProgressBar, manaProgressBar.Value + " / 1000");
            BackgroundImage = Constants.Backgrounds.ProtossBackground;
            BackgroundImageLayout = ImageLayout.Stretch; //TODO: update this
            UserSettingExtension.SetResolution(this);
            manaProgressBar.Minimum = 0;
            manaProgressBar.Maximum = 1000;
        }

        private void ProtossPanel_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            Opacity = 100;
            _controller = new CardController(this, new Size(100, 100),null, 14);
            Timer1.Interval = 100;
            _controller.CreateCards();
        }

        #region Game Systems
        public void DisplayScoreCombo(int Score, int Combo)
        {
            if (Score < 10)
                PlayerScorelbl.Text = "000" + Score.ToString();
            else if (Score < 100)
                PlayerScorelbl.Text = "00" + Score.ToString();
            else if (Score < 1000)
                PlayerScorelbl.Text = "0" + Score.ToString();
            else
                PlayerScorelbl.Text = Score.ToString();
            if (Combo < 10)
                Combolbl.Text = " " + Combo.ToString() + "X";
            else
                Combolbl.Text = Combo.ToString() + "X";
        }

        public void RoundCleanup()
        {
            Timer1.Stop();
            PowerUpBtn.Enabled = false;
            GameStartBtn.Text = "START";
            GameStartBtn.Enabled = true;
        }

        public void LevelAdvance()
        {
            preMana = manaProgressBar.Value;
            progressBar1.Value = 1;
            TimeLabel.Text = "00:00";

            _controller.CreateCards();
            ActiveForm.Text = "Level " + _controller.Level;
        }

        public void UpdateManaProgressBar(int value)
        {
            if (manaProgressBar.Value + value > manaProgressBar.Maximum)
                manaProgressBar.Value = manaProgressBar.Maximum;
            else
                manaProgressBar.Value += value;

            toolTip1.SetToolTip(manaProgressBar, manaProgressBar.Value + " / 1000");
        }
        #endregion

        #region Sound Setting
        public void BGMStart()
        {
            if (UserSetting.MusicEnabled && !MusicPlaying)
            {
                MusicPlaying = true;
                if(BGMPlayer.Source == null)
                    BGMPlayer.Open(new Uri("Resources/Audio/ArtanisBGM.wav", UriKind.Relative));
                BGMPlayer.Play();
                BGMPlayer.MediaEnded += BGMPlayer_MediaEnded;
            }
        }
        public void BGMStop()
        {
            BGMPlayer.Pause();
            MusicPlaying = false;
        }
        private void BGMPlayer_MediaEnded(object sender, EventArgs e)
        {
            MusicPlaying = false;
            BGMStart();
        }

        #endregion
        public void SetGameTimerStatus(bool isStarted)
        {
            if (isStarted)
            {
                Timer1.Start();
                return;
            }

            Timer1.Stop();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (_controller.GameIsPaused || !_controller.GameIsInProgress)
                return;

            manaProgressBar.Step = 10;
            manaProgressBar.PerformStep();
            toolTip1.SetToolTip(manaProgressBar, manaProgressBar.Value + " / 1000");

            progressBar1.Minimum = 1;
            progressBar1.Maximum = _controller.LevelTime * 10;
            progressBar1.Step = 1;
            progressBar1.PerformStep();

            var remainingTime = _controller.GetRemainingTime();
            var minutesLabel = remainingTime.Minutes < 10 ? $"0{remainingTime.Minutes}" : remainingTime.Minutes.ToString();
            var secondsRoundup = Math.Ceiling(remainingTime.Seconds + (remainingTime.Milliseconds / 1000.0));
            var secondsLabel = secondsRoundup < 10 ? $"0{secondsRoundup}" : secondsRoundup.ToString();
            TimeLabel.Text = $"{minutesLabel}:{secondsLabel}";

            if(remainingTime.TotalSeconds <= 0)
                Timer1.Stop();
        }

        #region Game Buttons
        private async void GameStartBtn_Click(object sender, EventArgs e)
        {
            if (GameStartBtn.Text == "START")
            {
                SetGameTimerStatus(true);
                GameStartBtn.Enabled = false;
                BGMStart();
                _controller.DisplayCards();
                await Task.Delay(500);
                await _controller.RoundStart();
                GameStartBtn.Text = "REPLAY";
                PowerUpBtn.Enabled = true;
                GameStartBtn.Enabled = true;
            }
            else
            {
                progressBar1.Value = 1;
                manaProgressBar.Step = preMana - manaProgressBar.Value;
                manaProgressBar.PerformStep();
                toolTip1.SetToolTip(manaProgressBar, manaProgressBar.Value + " / 1000");
                PowerUpBtn.Enabled = false;
                GameStartBtn.Text = "START";

                _controller.RoundRestart();
            }
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
                    if (UserSetting.MusicEnabled && _controller.GameIsInProgress)
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
                    menuIsDismissed = true;
                    ExitGame = false;
                    BGMPlayer.Stop();
                    Close();
                    FirstPanel FP = new FirstPanel();
                    FP.Show();
                    break;

                case 4:
                    menuIsDismissed = true;
                    Application.Exit();
                    break;

                default:
                    menuIsDismissed = true;
                    break;
            }

            if (menuIsDismissed)
            {
                UserSettingExtension.SetResolution(this);
                _controller.ResumeGame();
                SetGameTimerStatus(true);

                return;
            }

            MenuBtn_Click(sender, e);
        }

        private async void PowerUpBtn_Click(object sender, EventArgs e)
        {
            int result = PowerSkill.Show(ActiveForm, PowerUpBtn.Location.X,PowerUpBtn.Location.Y);

            if (!_controller.GameIsInProgress || _controller.GameOver)
                return;

            switch (result)
            {
                case 1:
                    if(manaProgressBar.Value >= 500)
                    {
                        manaProgressBar.Step = -500;
                        manaProgressBar.PerformStep();
                        _controller.RevealCards(1.5);
                    }
                    else
                    {
                        MessageBox.Show("You have not enough Energy!", "Error");
                    }
                    break;
                case 2:
                    if (manaProgressBar.Value >= 200)
                    {
                        manaProgressBar.Step = -200;
                        manaProgressBar.PerformStep();
                        await _controller.InstantPair();
                    }
                    else
                    {
                        MessageBox.Show("You have not enough Energy!", "Error");
                    }
                    break;
                default:
                    break;
            }
        }
        private void ProtossPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            BGMPlayer.Stop();
            if (ExitGame)
            {
                MessageBox.Show("Thank you for playing this game!", "Exit Game");
                Application.Exit();
            }
        }
        #endregion
        public void GameOver()
        {
            progressBar1.Value = 1;
            GameStartBtn.Text = "REPLAY";
            PowerUpBtn.Enabled = false;
        }

    }
}