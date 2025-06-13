namespace WindowsFormsApplication1
{
    partial class NextLevelRevealDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UnitRevealBox = new System.Windows.Forms.PictureBox();
            this.LevelAdvancedLabel = new System.Windows.Forms.Label();
            this.ScoreSummaryLabel = new System.Windows.Forms.Label();
            this.NextLevelLabel = new System.Windows.Forms.Label();
            this.NextLevelDetailsLabel = new System.Windows.Forms.Label();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.EndGameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UnitRevealBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UnitRevealBox
            // 
            this.UnitRevealBox.Location = new System.Drawing.Point(328, 133);
            this.UnitRevealBox.Name = "UnitRevealBox";
            this.UnitRevealBox.Size = new System.Drawing.Size(100, 100);
            this.UnitRevealBox.TabIndex = 0;
            this.UnitRevealBox.TabStop = false;
            // 
            // LevelAdvancedLabel
            // 
            this.LevelAdvancedLabel.AutoSize = true;
            this.LevelAdvancedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelAdvancedLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.LevelAdvancedLabel.Location = new System.Drawing.Point(122, 9);
            this.LevelAdvancedLabel.Name = "LevelAdvancedLabel";
            this.LevelAdvancedLabel.Size = new System.Drawing.Size(187, 25);
            this.LevelAdvancedLabel.TabIndex = 1;
            this.LevelAdvancedLabel.Text = "Level Advanced!";
            // 
            // ScoreSummaryLabel
            // 
            this.ScoreSummaryLabel.AutoSize = true;
            this.ScoreSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreSummaryLabel.Location = new System.Drawing.Point(12, 34);
            this.ScoreSummaryLabel.Name = "ScoreSummaryLabel";
            this.ScoreSummaryLabel.Size = new System.Drawing.Size(425, 54);
            this.ScoreSummaryLabel.TabIndex = 2;
            this.ScoreSummaryLabel.Text = "Good job Executor! At this rate, Aiur will be reclaimed in no time!\r\nScore:\r\nTime" +
    " Spent: ? (+ ? Bonus Score!)";
            // 
            // NextLevelLabel
            // 
            this.NextLevelLabel.AutoSize = true;
            this.NextLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextLevelLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.NextLevelLabel.Location = new System.Drawing.Point(11, 98);
            this.NextLevelLabel.Name = "NextLevelLabel";
            this.NextLevelLabel.Size = new System.Drawing.Size(97, 20);
            this.NextLevelLabel.TabIndex = 3;
            this.NextLevelLabel.Text = "Next Level:";
            // 
            // NextLevelDetailsLabel
            // 
            this.NextLevelDetailsLabel.AutoSize = true;
            this.NextLevelDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextLevelDetailsLabel.Location = new System.Drawing.Point(12, 133);
            this.NextLevelDetailsLabel.Name = "NextLevelDetailsLabel";
            this.NextLevelDetailsLabel.Size = new System.Drawing.Size(116, 80);
            this.NextLevelDetailsLabel.TabIndex = 4;
            this.NextLevelDetailsLabel.Text = "Game Time: ???s\r\nBase Score: ???\r\nTotal Panels: ???\r\nNew Unit: ???????\r\nAdditiona" +
    "l Effects:";
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.Location = new System.Drawing.Point(37, 242);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(163, 28);
            this.ContinueBtn.TabIndex = 5;
            this.ContinueBtn.Text = "Continue";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // EndGameBtn
            // 
            this.EndGameBtn.Location = new System.Drawing.Point(235, 242);
            this.EndGameBtn.Name = "EndGameBtn";
            this.EndGameBtn.Size = new System.Drawing.Size(163, 28);
            this.EndGameBtn.TabIndex = 6;
            this.EndGameBtn.Text = "End Game";
            this.EndGameBtn.UseVisualStyleBackColor = true;
            this.EndGameBtn.Click += new System.EventHandler(this.EndGameBtn_Click);
            // 
            // NextLevelRevealDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 278);
            this.ControlBox = false;
            this.Controls.Add(this.EndGameBtn);
            this.Controls.Add(this.ContinueBtn);
            this.Controls.Add(this.NextLevelDetailsLabel);
            this.Controls.Add(this.NextLevelLabel);
            this.Controls.Add(this.ScoreSummaryLabel);
            this.Controls.Add(this.LevelAdvancedLabel);
            this.Controls.Add(this.UnitRevealBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NextLevelRevealDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextLevelRevealDialog";
            ((System.ComponentModel.ISupportInitialize)(this.UnitRevealBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UnitRevealBox;
        private System.Windows.Forms.Label LevelAdvancedLabel;
        private System.Windows.Forms.Label ScoreSummaryLabel;
        private System.Windows.Forms.Label NextLevelLabel;
        private System.Windows.Forms.Label NextLevelDetailsLabel;
        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.Button EndGameBtn;
    }
}