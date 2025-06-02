using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class FirstPanel : Form
    {
        static bool firstload;
        public FirstPanel()
        {
            Shown += FirstPanel_Shown;
            InitializeComponent();
            ClassicBtn.Visible = false;
            ChooseModeLabel.Visible = false;
            DesBtn.Visible = false;
            ModeBackBtn.Visible = false;
            AiurBtn.Visible = false;
            ChooseThemeLabel.Visible = false;
            ThemeBackBtn.Visible = false;
            if (firstload == false)
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.StartSound);
                sp.Play();
                firstload = true;
            }
        }

        private void FirstPanel_Shown(object sender, EventArgs e)
        {
            ExitBtn.Visible = true;
            StartBtn.Visible = true;
            Welcome1.Visible = true;
            Welcome2.Visible = true;
            InsBtn.Visible = true;
            Application.DoEvents();
            ActiveForm.Opacity = 100;
        }

        private void InsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Match 2 pairs to make them disappear, that's all c:", "Instructions");
        }

        private void ExitMainBtn_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Hide();
            InsBtn.Hide();
            ExitBtn.Hide();
            Welcome1.Hide();
            Welcome2.Hide();
            ClassicBtn.Visible = true;
            ChooseModeLabel.Visible = true;
            DesBtn.Visible = true;
            ModeBackBtn.Visible = true;
        }

        private void ModeBackBtn_Click(object sender, EventArgs e)
        {
            ClassicBtn.Visible = false;
            ChooseModeLabel.Visible = false;
            DesBtn.Visible = false;
            ModeBackBtn.Visible = false;
            StartBtn.Show();
            InsBtn.Show();
            ExitBtn.Show();
            Welcome1.Show();
            Welcome2.Show();
        }
        int Mode; //Mode = 0 -> Classic, = 1 -> Destruction
        private void DesBtn_Click(object sender, EventArgs e)
        {
            Mode = 1;
            MessageBox.Show("Destruction Mode is not available in this beta version.", "In Development");
        }

        private void ClassicBtn_Click(object sender, EventArgs e)
        {
            Mode = 0;
            ClassicBtn.Visible = false;
            ChooseModeLabel.Visible = false;
            DesBtn.Visible = false;
            ModeBackBtn.Visible = false;
            //Choose a theme to play
            AiurBtn.Visible = true;
            ChooseThemeLabel.Visible = true;
            ThemeBackBtn.Visible = true;
        }

        private void ThemeBackBtn_Click(object sender, EventArgs e)
        {
            ClassicBtn.Visible = true;
            ChooseModeLabel.Visible = true;
            DesBtn.Visible = true;
            ModeBackBtn.Visible = true;
            AiurBtn.Visible = false;
            ChooseThemeLabel.Visible = false;
            ThemeBackBtn.Visible = false;
        }

        private void AiurBtn_Click(object sender, EventArgs e)
        {
            if (Mode == 0)
            {
                ProtossPanel PP = new ProtossPanel();
                Hide();
                PP.Show();
            }
        }
    }
}
