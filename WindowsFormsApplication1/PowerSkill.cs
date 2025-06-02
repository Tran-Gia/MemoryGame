using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PowerSkill : Form
    {
        static int result;
        public PowerSkill()
        {
            InitializeComponent();
        }
        public static int Show(Form A,int x,int y)
        {
            PowerSkill form = new PowerSkill();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(A.Location.X + x + 10, A.Location.Y + y - 230);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Yes)
                return result;
            return 0;
        }

        private void RevealBtn_Click(object sender, EventArgs e)
        {
            result = 1;
            DialogResult = DialogResult.Yes;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            result = 0;
            DialogResult = DialogResult.No;
        }

        private void BtnInstantPair_Click(object sender, EventArgs e)
        {
            result = 2;
            DialogResult = DialogResult.Yes;
        }
    }
}
