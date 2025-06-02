using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Media;
using System.Timers;
using System.Windows.Media;

namespace WindowsFormsApplication1
{
    //BGM is shitty with Uri, check for solution
    public partial class ProtossPanel : Form
    {
        #region properties
        Button[] b;
        bool MusicOn = true;
        bool MusicPlaying = false;
        bool ExitGame = true;
        Random r = new Random();
        private object locker = new object();
        int n = 16; //n stands for number of pictures in a level.
        int level = 1; //Will have code to save levels later, but not now.
        int type = 4; //Determine how many types of unit available in a level.
        int time = 120 ;
        int basescore = 10;
        int MAXunit = 0; //determines how many types available of a faction.
        int preMana = 0;
        ToolTip toolTip1;
        List<Image> ImageList;
        MediaPlayer BGMPlayer;
        string ImagePath, AudioPath;
        System.Timers.Timer wait, CheckPairDelay;
        bool Checking = false;
        int dem , Score , Sound = 0;
        int Combo = 1;
        bool SoundOn = true;
        private DateTime CurTime;
        int sec;
        int min;
        int progress;
        List<string> Unit = new List<string>();
        int[] openedBtns = { -1, -1 };
        #endregion
        public ProtossPanel()
        {
            Shown += ProtossPanel_Shown;
            FormClosed += ProtossPanel_FormClosed;
            FilePathSetting();
            InitializeComponent();
            ImageInstaller();
            BGMPlayer = new MediaPlayer();
            PauseBtn.Enabled = false;
            PowerUpBtn.Enabled = false;
            toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(manaProgressBar, manaProgressBar.Value + " / 1000");
        }
        private void ProtossPanel_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            Opacity = 100;
            CreateNewButtons();
        }
        #region Game Systems
        public void FilePathSetting()
        {
            #region Protoss
            ImagePath = "Protoss_Image_";
            AudioPath = "Protoss_Audio_";
            Unit.Add("None"); Unit.Add("Probe"); Unit.Add("Zealot"); Unit.Add("Stalker");
            Unit.Add("Adept"); Unit.Add("Sentry"); Unit.Add("Immortal"); Unit.Add("Warp Prism");
            Unit.Add("Observer"); Unit.Add("Dark Templar"); Unit.Add("High Templar"); Unit.Add("Archon");
            Unit.Add("Phoenix"); Unit.Add("Oracle"); Unit.Add("Void Ray"); Unit.Add("Collosus");
            Unit.Add("Disruptor"); Unit.Add("Carrier"); Unit.Add("Tempest"); Unit.Add("Mothership");
            #endregion
            MAXunit = Unit.Count;
        }
        public void ImageInstaller()
        {
            ImageList = new List<Image>();
            try
            {
                string num =  "";
                ImageList.Add((Image)Properties.Resources.ResourceManager.GetObject(ImagePath + "Default"));
                string skin = "_Original";
                for (int i = 1; i < MAXunit; i++)
                {
                    if (i < 10)
                        num = "0" + i;
                    else
                        num = "" + i;
                    Image temp = (Image)Properties.Resources.ResourceManager.GetObject(ImagePath + num + skin);
                    if(temp != null)
                    {
                        ImageList.Add(temp);
                    }
                    else
                    {
                        ImageList.Add((Image)Properties.Resources.ResourceManager.GetObject(ImagePath + num + "_Carbot"));
                    }
                }
            } catch
            {

            }
        }
        public void RevealAllImages()
        {
            Checking = true; //Prevent abuse clicking when pics are revealed
            foreach (var button in b) 
            {
                lock (locker) //prevent InvalidOperationException
                {
                    button.Image = ImageList[Convert.ToInt32(button.Tag.ToString())];
                }
            }
            if (wait == null)
            {
                wait = new System.Timers.Timer(1500);
                wait.Enabled = true;
                ElapsedEventHandler InnerMethod = (object sender,ElapsedEventArgs e) =>
                {
                    wait.Stop();
                    foreach (var button in b)
                    {
                        lock (locker)
                        {
                        if (Array.IndexOf(b,button) != openedBtns[0])
                                button.Image = ImageList[0];
                        }
                    }
                    Checking = false;
                };
                wait.Elapsed += InnerMethod;
                wait.AutoReset = false;
            }
            wait.Start();
        }
        public void InstantPair()
        {
            int b1 = 0;
            int b2 = 0;
            if (openedBtns[0] != -1)
            {
                b1 = openedBtns[0];
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i].IsDisposed)
                    {
                        b1 = i;
                        break;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (b[i].Tag.ToString() == b[b1].Tag.ToString() && i != b1 && b[i].IsDisposed == false)
                {
                    b2 = i;
                }
            }

            if (openedBtns[0] != -1)
            {
                b_Click(b[b2], new EventArgs());
            }
            else
            {
                b_Click(b[b1], new EventArgs());
                System.Threading.Thread.Sleep(50);
                b_Click(b[b2], new EventArgs());
            }
        }

        public void CreateNewButtons()
        {
            b = new Button[n];
            int k = 0, j = 1;
            for (int i = 0; i < n; i++)
            {
                b[i] = new Button();
                b[i].Size = new Size(100, 100);
                b[i].Text = "";
                b[i].Image = ImageList[0];
                b[i].Location = new Point(70 + k * 105, -70 + j * 105);
                b[i].Enabled = false;
                b[i].Click += new EventHandler(b_Click);
                Controls.Add(b[i]);
                k++;
                if (k == 4 + (level+4)/8)
                {
                    k = 0; j++;
                }
            }

        }
        public void b_Click(object sender, EventArgs e)
        {
            if (Checking == false)
            {
                Button clickedBtn = (Button)sender;
                clickedBtn.Image = ImageList[Convert.ToInt32(clickedBtn.Tag.ToString())];
                clickedBtn.Enabled = false;
                clickedBtn.Enabled = true;
                clickedBtn.Text = " ";
                Checkpair(Array.IndexOf(b, clickedBtn));
                CheckLength();
            }
        }
        public void random()
        {
            //Half Button Array to randomize number from 1 -> 11
            //Their tag is their true imageID
            ArrayList list = new ArrayList();
            for (int i = 0; i < n / 2; i++)
            {
                int j = r.Next(1, type);
                b[i].Tag = j;
                list.Add(j);//Save randomized numbers into list
            }
            for (int i = n / 2; i < n; i++)
            {
                int x = r.Next(0, list.Count - 1); // Take 1 number from the list randomly
                b[i].Tag = list[x];//Random object that has x in the list.
                list.RemoveAt(x);//Remove object that has x in the list.
            }
        }
        private void DisplayScoreCombo(int Score, int Combo)
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
        public void Checkpair(int btnIndex)
        {
            if (openedBtns[0] == -1 || openedBtns[0] == btnIndex)
                openedBtns[0] = btnIndex;
            else
            {
                openedBtns[1] = btnIndex;
                Checking = true;
                if (CheckPairDelay == null)
                {
                    CheckPairDelay = new System.Timers.Timer(50);
                    CheckPairDelay.Enabled = true;
                    ElapsedEventHandler InnerMethod = (object sender, ElapsedEventArgs e) =>
                    {
                        CheckPairDelay.Stop();
                        Checking = false;
                    };
                    CheckPairDelay.Elapsed += InnerMethod;
                    CheckPairDelay.AutoReset = false;
                }
                //If 2 buttons are opened, then remove them from play.
                if (b[openedBtns[0]].Tag.ToString() == b[openedBtns[1]].Tag.ToString())
                {
                    Sound = (int)b[openedBtns[0]].Tag;
                    correctSound(Sound);
                    System.Threading.Thread.Sleep(150);
                    foreach (var openedBtn in openedBtns)
                    {
                        b[openedBtn].Dispose();
                    }
                    Score = Score + basescore * Combo;
                    Combo++;
                    DisplayScoreCombo(Score, Combo);
                    dem++;
                    manaProgressBar.Step = 10 + 3 * Combo;
                    manaProgressBar.PerformStep();
                    toolTip1.SetToolTip(manaProgressBar, manaProgressBar.Value + " / 1000");
                }
                else
                {
                    //wrongSound(); //too annoying.
                    System.Threading.Thread.Sleep(200);
                    foreach (var openedBtns in openedBtns)
                    {
                        b[openedBtns].Image = ImageList[0];
                    }
                    Combo = 1;
                    if (Score >= 12)
                        Score = Score - 2;
                    DisplayScoreCombo(Score, Combo);
                }
                CheckPairDelay.Start();
                foreach (var openedBtn in openedBtns)
                {
                    b[openedBtn].Text = " ";
                }
                openedBtns[0] = -1;
                openedBtns[1] = -1;
            }

        }
        public void CheckLength()
        {
            if (dem == n / 2)
            {
                //low score conversion at low stage, but increase every 2 , 4 , 10 levels.
                //At lv20: score += time *(0.5 + 2.5 + 2.5 + 2 ),by then max time = 40 -> max + score = 300.
                //Max score:     60 - 86.25 - 82.5 - 157.5 - 150 - 166.25 - 157.5 - 212.5
                //Time:         120 - 115   - 110  - 105   - 100 -   95   -  90   -  85
                //Conversion:   0.5 - 0.75  - 0.75 - 1.5   - 1.5 -  1.75  - 1.75  - 2.5
                timer1.Stop();
                PauseBtn.Enabled = false;
                PowerUpBtn.Enabled = false;
                GameStartBtn.Text = "Start";
                GameStartBtn.Enabled = true;
                LevelResult();
            }
        }
        public void LevelResult()
        {
            int timeLeft = time - progressBar1.Value;
            int bonusScore = 0;
            bonusScore = timeLeft / 2 + timeLeft / 4 * (level / 2) + timeLeft / 2 * (level / 4) + timeLeft * (level / 10);
            Score += bonusScore;
            int typeinput; //in case no new unit was added, typeinput returns 0 instead
            if (type < MAXunit)
            {
                type++;
                typeinput = type - 1;
            }
            else
                typeinput = 0;
            if (level < 40)
                level++;
            if (time > 45)
                time -= 5;
            if (level % 4 == 0)
                n += 2;
            if (level % 3 == 0)
                basescore += 2;
            int advance = NextLevelRevealDialog.NextLevelDetails(Score, progressBar1.Value, bonusScore, time,basescore, n,Unit[typeinput], ImageList[typeinput]);
            if (advance == 1)
                LevelAdvance();
            else
                MessageBox.Show("Final Score: " + Score);
        }
        public void LevelAdvance()
        {
            preMana = manaProgressBar.Value;
            Combo = 1;
            DisplayScoreCombo(Score, Combo);
            for (int i = 0; i < b.Length; i++)
            {
                b[i].Visible = false;
                b[i].Dispose();
            }
            CreateNewButtons();
            ProtossPanel.ActiveForm.Text = "Level " + level;
        }
        #endregion

        #region Sound Setting
        public void BGMStart()
        {
            if (MusicOn & !MusicPlaying)
            {
                MusicPlaying = true;
                BGMPlayer.Open(new Uri("Audio/ArtanisBGM.wav", UriKind.Relative));
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
        private void correctSound(int Sound)
        {
            //SoundOn = true -> Play, if false -> Mute.
            string num = "" + Sound;
            if (SoundOn)
            {
                try
                {
                    if (Sound < 10)
                        num = "0" + Sound;
                    SoundPlayer sp = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject(AudioPath + num));
                    sp.Play();
                }
                catch {
                    throw new Exception();
                }
            }
        }
        private void wrongSound()
        {
            SoundPlayer sp = new SoundPlayer("P" + "Wrong.wav");
            sp.Play();
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            //tick is based on its timer interval, but the actual timing is based on your clock.
            TimeSpan diff = new TimeSpan();
            diff = CurTime - DateTime.Now;
            min = (int) diff.TotalMinutes;
            sec = (int) diff.TotalSeconds;

            manaProgressBar.Minimum = 0;
            manaProgressBar.Maximum = 1000;
            manaProgressBar.Step = 10;
            manaProgressBar.PerformStep();
            toolTip1.SetToolTip(manaProgressBar, manaProgressBar.Value + " / 1000");

            progressBar1.Minimum = 0;
            progressBar1.Maximum = time;
            progressBar1.Step = time - sec - progress; //if time - sec - progress = 0 -> step = 0;
            progress = time - sec;
            progressBar1.PerformStep();
            // sec can't be larger than 60.
            for (int i = 0; i < 60; i++)
                if (sec >= 60)
                    sec -= 60;
            TimeLabel.Text = min + " : " + sec;
            if (min == 0 && sec == 0)
            {
                timer1.Stop();
                MessageBox.Show("Aiur has fallen to the Zergs.\nIt will never be restored again.\nFinal Score: " + Score, "Mission Failed!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                GameOver();
            }
        }
        #region Game Buttons
        private void GameStartBtn_Click(object sender, EventArgs e)
        {
            if (GameStartBtn.Text == "Start")
            {
                BGMStart();
                timer1.Start();
                //remove remaining buttons on the panel if lost.
                for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i].Text == "")
                            b[i].Enabled = true;
                        else
                            b[i].Enabled = false;
                    }
                random();
                RevealAllImages();
                CurTime = new DateTime();
                CurTime = DateTime.Now;
                CurTime = CurTime.AddSeconds(time);
                GameStartBtn.Text = "Replay";
                PauseBtn.Enabled = true;
                PowerUpBtn.Enabled = true;
                dem = 0;
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
                Combo = 1;
                Score = Score/2;
                DisplayScoreCombo(Score, Combo);
                foreach (var button in b)
                {
                    button.Visible = false;
                    button.Dispose();
                }
                CreateNewButtons();
            }
        }
        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (PauseBtn.Text == "Pause")
            {
                BGMPlayer.Stop();
                GameStartBtn.Enabled = false;
                PowerUpBtn.Enabled = false;
                timer1.Stop();
                TimeSpan diff = new TimeSpan();
                diff = CurTime - DateTime.Now;
                sec = (int)diff.TotalSeconds; //screw x.99 seconds
                PauseBtn.Text = "Resume";
                for (int i = 0; i < b.Length; i++)
                    b[i].Enabled = false;
            }
            else
            {
                //Pause text = resume
                BGMPlayer.Play();
                GameStartBtn.Enabled = true;
                PowerUpBtn.Enabled = true;
                CurTime = new DateTime();
                CurTime = DateTime.Now;
                CurTime = CurTime.AddSeconds(sec);
                timer1.Start();
                PauseBtn.Text = "Pause";
                for (int i = 0; i < b.Length; i++)
                    b[i].Enabled = true;
            }
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
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
                        if (PauseBtn.Enabled || level>1)
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
                    Application.Exit();
                    break;
                #endregion
                #region case 5: Cancel
                case 5:
                    break;
                #endregion
            }
        }

        private void PowerUpBtn_Click(object sender, EventArgs e)
        {
            int result = PowerSkill.Show(ProtossPanel.ActiveForm, PowerUpBtn.Location.X,PowerUpBtn.Location.Y);
            switch (result)
            {
                case 1:
                    if(manaProgressBar.Value >= 500)
                    {
                        manaProgressBar.Step = -500;
                        manaProgressBar.PerformStep();
                        RevealAllImages();
                    }
                    else
                    {
                        MessageBox.Show("You have not enough Mana!", "Error");
                    }
                    break;
                case 2:
                    if (manaProgressBar.Value >= 200)
                    {
                        manaProgressBar.Step = -200;
                        manaProgressBar.PerformStep();
                        InstantPair();
                    }
                    else
                    {
                        MessageBox.Show("You have not enough Mana!", "Error");
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
        private void GameOver()
        {
            GameStartBtn.Text = "Replay";
            PauseBtn.Enabled = false;
            PowerUpBtn.Enabled = false;
            for (int i = 0; i < b.Length; i++)
            {
                b[i].Image = ImageList[Convert.ToInt32(b[i].Tag.ToString())];
                b[i].Enabled = false;
            }
        }

    }
}