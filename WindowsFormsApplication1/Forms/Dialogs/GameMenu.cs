using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.Enums;
using WindowsFormsApplication1.Functions.UserSettings;

namespace WindowsFormsApplication1
{
    public partial class GameMenu : Form
    {
        static int result;
        public GameMenu()
        {
            InitializeComponent();

            var musicStatus = UserSetting.MusicEnabled ? "ON" : "OFF";
            var soundStatus = UserSetting.SoundEnabled ? "ON" : "OFF";

            MusicBtn.Text = $"Music: {musicStatus}";
            SoundBtn.Text = $"Sound: {soundStatus}";

            ResolutionCboBox.ValueMember = "Resolution";
            ResolutionCboBox.DisplayMember = "ResolutionName";
            ResolutionCboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var resolutionList = Enum.GetValues(typeof(Resolution)).Cast<Resolution>()
                .Select(e => new UserResolution{
                    Resolution = e, ResolutionName = e.ToString().Trim('_') 
                }).ToList();

            ResolutionCboBox.DataSource = resolutionList;
            ResolutionCboBox.SelectedItem = resolutionList.FirstOrDefault(
                x => x.Resolution == UserSetting.Resolution);
            ResolutionCboBox.SelectedIndexChanged += ResolutionCboBox_SelectedIndexChanged;
        }

        public static int MenuRequest()
        {
            //Music (1) - Sound (2) - Exit To Menu (3) - Exit Game (4) - Cancel (5)
            GameMenu menu = new GameMenu
            {
                StartPosition = FormStartPosition.CenterParent,
            };
            menu.ShowDialog();

            return menu.DialogResult == DialogResult.Yes ? result : 0;
        }
        private void BackMenuBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void MusicBtn_Click(object sender, EventArgs e)
        {
            UserSetting.MusicEnabled = !UserSetting.MusicEnabled;

            result = 1;
            DialogResult = DialogResult.Yes;
        }

        private void SoundBtn_Click(object sender, EventArgs e)
        {
            UserSetting.SoundEnabled = !UserSetting.SoundEnabled;

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

        private void ResolutionCboBox_SelectedIndexChanged (object sender, EventArgs e)
        {
            var selectedItem  = (UserResolution)ResolutionCboBox.SelectedItem;
            UserSetting.Resolution = selectedItem.Resolution;
        }
    }
}
