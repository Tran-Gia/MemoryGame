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
    public partial class NextLevelRevealDialog : Form
    {
        public NextLevelRevealDialog()
        {
            InitializeComponent();
        }
        public static int NextLevelDetails(int score,int timespent, int bonusScore,int gametime,int basescore, int panels,string unit, Image UnitImage)
        {
            //score , timespent, bonusScore, gametime, basescore, panels, UnitImage
            NextLevelRevealDialog form = new NextLevelRevealDialog();
            form.ScoreSummaryLabel.Text = "Good job Executor! At this rate, Aiur will be reclaimed in no time!\nScore:"
                + score + "\nTime Spent: " + timespent + " (+ " + bonusScore + " Bonus Score!)";
            form.NextLevelDetailsLabel.Text = "Game Time: " + gametime +"\nBase Score: "
                + basescore + "\nTotal Panels: "+ panels + "\nNew Unit: " + unit + "\nAdditional effects: Not available in this version";
            form.UnitRevealBox.Image = UnitImage;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Yes)
                return 1;
            return 0;
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void EndGameBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
        
    }
}
