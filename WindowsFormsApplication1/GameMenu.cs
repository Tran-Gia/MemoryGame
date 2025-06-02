using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GameMenu : Form
    {
        static bool firstload = true;
        static int result;
        static string MusicBtnName;
        static string SoundBtnName;
        public GameMenu()
        {
            InitializeComponent();
            if (firstload)
            {
                MusicBtnName = MusicBtn.Text;
                SoundBtnName = SoundBtn.Text;
                firstload = false;
            }
            else
            {
                MusicBtn.Text = MusicBtnName;
                SoundBtn.Text = SoundBtnName;
            }
        }
        public static int MenuRequest()
        {
            //Music (1) - Sound (2) - Exit To Menu (3) - Exit Game (4) - Cancel (5)
            GameMenu menu = new GameMenu();
            menu.ShowDialog();
            if(menu.DialogResult == DialogResult.Yes)
                return result;
            return 0;
        }
        private void BackMenuBtn_Click(object sender, EventArgs e)
        {
            result = 5;
            DialogResult = DialogResult.Yes;
        }

        private void MusicBtn_Click(object sender, EventArgs e)
        {
            if (MusicBtnName == "Music: ON")
            {
                MusicBtnName = "Music: OFF";
            }
            else
            {
                MusicBtnName = "Music: ON";
            }
            result = 1;
            DialogResult = DialogResult.Yes;
        }

        private void SoundBtn_Click(object sender, EventArgs e)
        {
            if (SoundBtnName == "Sound: ON")
            {
                SoundBtnName = "Sound: OFF";
            }
            else
            {
                SoundBtnName = "Sound: ON";
            }
            result = 2;
            DialogResult = DialogResult.Yes;
        }

        private void ExitToMenuBtn_Click(object sender, EventArgs e)
        {
            result = 3;
            DialogResult = DialogResult.Yes;
        }

        private void ExitGameBtn_Click(object sender, EventArgs e)
        {
            result = 4;
            DialogResult = DialogResult.Yes;
        }
    }
}
