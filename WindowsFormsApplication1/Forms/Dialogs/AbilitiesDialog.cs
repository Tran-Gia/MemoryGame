using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1.Enums;

namespace WindowsFormsApplication1
{
    public partial class AbilitiesDialog : Form
    {

        static Ability? castedAbility;

        public AbilitiesDialog()
        {
            InitializeComponent();
        }

        public static Ability? Show(Form owner, int btnX, int btnWidth, int btnY, int btnHeight)
        {
            AbilitiesDialog dialog = new AbilitiesDialog
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(owner.Location.X + btnX + btnWidth + 10, owner.Location.Y + btnY + btnHeight/2)
            };

            dialog.Location = new Point(
                dialog.Location.X - dialog.Width,
                dialog.Location.Y - dialog.Height
            );

            dialog.ShowDialog();

            return castedAbility;
        }

        private void SolarPanelsBtn_Click(object sender, EventArgs e)
        {
            castedAbility = Ability.SolarPanels;
            DialogResult = DialogResult.Yes;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            castedAbility = null;
            DialogResult = DialogResult.No;
        }

        private void InstantPairBtn_Click(object sender, EventArgs e)
        {
            castedAbility = Ability.InstantPair;
            DialogResult = DialogResult.Yes;
        }
    }
}
