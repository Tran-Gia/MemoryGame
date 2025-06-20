using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NextLevelRevealDialog : Form
    {
        public NextLevelRevealDialog()
        {
            InitializeComponent();
        }
        public static bool NextLevelDetails(Form owner, int score,int timeSpent, int bonusScore,int levelTime,int baseScore, int cardsAmount,string nextUnit, Image nextUnitImage)
        {
            //TODO: A bug is occurred where the PowerSkill dialog is present when the round is won, so this dialog will appear on top of it.
            NextLevelRevealDialog form = new NextLevelRevealDialog
            {
                StartPosition = FormStartPosition.CenterParent
            };
            form.UnitRevealBox.Image = nextUnitImage;

            form.ScoreSummaryLabel.Text = $"Good job Executor! At this rate, Aiur will be reclaimed in no time!" +
                $"\nScore: {score}" +
                $"\nTime Spent:{timeSpent} (+ ${bonusScore} Bonus Score!)";

            form.NextLevelDetailsLabel.Text = $"Game Time: {levelTime}" + 
                $"\nBase Score: {baseScore}" +
                $"\nTotal Cards: {cardsAmount}" +
                $"\nNew Unit: {nextUnit}" +
                "\nAdditional effects: Not available in this version";

            form.ShowDialog(owner);
            return form.DialogResult == DialogResult.Yes;
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
