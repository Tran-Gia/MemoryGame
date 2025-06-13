using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WindowsFormsApplication1.Functions.Controllers;

namespace WindowsFormsApplication1
{
    //BGM is shitty with Uri, check for solution
    public partial class ProtossPanel : Form
    {
        #region properties
        bool MusicOn = true;
        bool MusicPlaying = false;
        bool ExitGame = true;
        int preMana = 0;
        readonly ToolTip toolTip1;
        readonly MediaPlayer BGMPlayer;
        bool SoundOn = true;
        private CardController _controller;
        #endregion
        public ProtossPanel()
        {
            Shown += ProtossPanel_Shown;
            FormClosed += ProtossPanel_FormClosed;
            InitializeComponent();
            BGMPlayer = new MediaPlayer();
            PauseBtn.Enabled = false;
            PowerUpBtn.Enabled = false;
            toolTip1 = new ToolTip
            {
                ShowAlways = true
            };
            toolTip1.SetToolTip(manaProgressBar, manaProgressBar.Value + " / 1000");
            BackgroundImage = Constants.Backgrounds.ProtossBackground;
            BackgroundImageLayout = ImageLayout.Stretch; //TODO: update this
            //CenterToScreen();
            ClientSize = new Size(1280, 720);
            //this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); //TODO: use Screen.PrimaryScreen.Bounds to get the current display resolution
        }

        private void ProtossPanel_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            Opacity = 100;
            _controller = new CardController(Controls, this, new Size(100, 100),null, 14);
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
            timer1.Stop();
            PauseBtn.Enabled = false;
            PowerUpBtn.Enabled = false;
            GameStartBtn.Text = "Start";
            GameStartBtn.Enabled = true;
        }

        public void LevelAdvance()
        {
            preMana = manaProgressBar.Value;
            progressBar1.Value = 1;
            TimeLabel.Text = "00 : 00";

            _controller.CreateCards();
            ActiveForm.Text = "Level " + _controller.Level;
        }
        #endregion

        #region Sound Setting
        public void BGMStart()
        {
            if (MusicOn && !MusicPlaying)
            {
                MusicPlaying = true;
                BGMPlayer.Open(new Uri("Resources/Audio/ArtanisBGM.wav", UriKind.Relative));
                BGMPlayer.Play();
                BGMPlayer.MediaEnded += BGMPlayer_MediaEnded;
            }
        }
        public void BGMStop()
        {
            BGMPlayer.Stop();
            BGMPlayer.Close();
            MusicOn = false;
            MusicPlaying = false;
        }
        private void BGMPlayer_MediaEnded(object sender, EventArgs e)
        {
            MusicPlaying = false;
            BGMStart();
        }

        #endregion
        private void Timer1_Tick(object sender, EventArgs e)
        {
            manaProgressBar.Minimum = 0;
            manaProgressBar.Maximum = 1000;
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
            TimeLabel.Text = $"{minutesLabel} : {secondsLabel}";

            if(remainingTime.TotalSeconds <= 0)
                timer1.Stop();
        }

        #region Game Buttons
        private async void GameStartBtn_Click(object sender, EventArgs e)
        {
            if (GameStartBtn.Text == "Start")
            {
                BGMStart();
                _controller.DisplayCards();
                await Task.Delay(600);
                await _controller.RoundStart();
                timer1.Start();
                GameStartBtn.Text = "Replay";
                PauseBtn.Enabled = true;
                PowerUpBtn.Enabled = true;
            }
            else
            {
                manaProgressBar.Step = preMana - manaProgressBar.Value;
                manaProgressBar.PerformStep();
                toolTip1.SetToolTip(manaProgressBar, manaProgressBar.Value + " / 1000");
                PowerUpBtn.Enabled = false;
                PauseBtn.Enabled = false;
                GameStartBtn.Text = "Start";
                timer1.Stop();
                //Combo = 1;
                //reduce score here ?

                _controller.CreateCards();
            }
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (PauseBtn.Text == "Pause")
            {
                BGMPlayer.Pause();
                GameStartBtn.Enabled = false;
                PowerUpBtn.Enabled = false;
                timer1.Stop();
                PauseBtn.Text = "Resume";

                _controller.SetGameState(false);
            }
            else
            {
                //Pause text = resume
                BGMPlayer.Play();
                GameStartBtn.Enabled = true;
                PowerUpBtn.Enabled = true;
                timer1.Start();
                PauseBtn.Text = "Pause";

                _controller.SetGameState(true);
            }
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            var menuIsDismissed = false;
            //Music (1) - Sound (2) - Exit To Menu (3) - Exit Game (4) - Cancel (5)
            int result = GameMenu.MenuRequest();
            switch (result)
            {
                #region case 1: Music
                case 1:
                    if (MusicOn)
                    {
                        BGMStop();
                    }
                    else
                    {
                        MusicOn = true;
                        if (PauseBtn.Enabled || _controller.Level>=1)
                            BGMStart();
                    }
                    break;
                #endregion
                #region case 2: Sound
                case 2:
                    if (SoundOn)
                    {
                        SoundOn = false;
                    }
                    else
                    {
                        SoundOn = true;
                    }
                    break;
                #endregion
                #region case 3: Exit To Menu
                case 3:
                    menuIsDismissed = true;
                    ExitGame = false;
                    BGMPlayer.Stop();
                    timer1.Stop();
                    this.Close();
                    FirstPanel FP = new FirstPanel();
                    FP.Show();
                    break;
                #endregion
                #region case 4: Exit Game
                case 4:
                    menuIsDismissed = true;
                    timer1.Stop();
                    _controller.SetGameState(false);
                    Application.Exit();
                    break;
                #endregion
                #region case 5: Cancel
                case 5:
                    menuIsDismissed = true;
                    break;
                #endregion
            }
            if (!menuIsDismissed)
                MenuBtn_Click(sender, e);
        }

        private async void PowerUpBtn_Click(object sender, EventArgs e)
        {
            int result = PowerSkill.Show(ProtossPanel.ActiveForm, PowerUpBtn.Location.X,PowerUpBtn.Location.Y);
            switch (result)
            {
                case 1:
                    if(manaProgressBar.Value >= 500)
                    {
                        manaProgressBar.Step = -500;
                        manaProgressBar.PerformStep();
                        _controller.RevealCards();
                        await Task.Delay(1500);
                        _controller.HideCards();
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
            GameStartBtn.Text = "Replay";
            PauseBtn.Enabled = false;
            PowerUpBtn.Enabled = false;

            _controller.RevealCards();
            _controller.SetGameState(false);
        }

    }
}