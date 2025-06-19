namespace WindowsFormsApplication1
{
    partial class FirstPanel
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
            this.components = new System.ComponentModel.Container();
            this.Welcome2 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.InsBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Welcome1 = new System.Windows.Forms.Label();
            this.Credit = new System.Windows.Forms.Label();
            this.ChooseModeLabel = new System.Windows.Forms.Label();
            this.ClassicBtn = new System.Windows.Forms.Button();
            this.ModeBackBtn = new System.Windows.Forms.Button();
            this.AiurBtn = new System.Windows.Forms.Button();
            this.ThemeBackBtn = new System.Windows.Forms.Button();
            this.ChooseThemeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcome2
            // 
            this.Welcome2.AutoSize = true;
            this.Welcome2.BackColor = System.Drawing.Color.Transparent;
            this.Welcome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome2.ForeColor = System.Drawing.Color.Lime;
            this.Welcome2.Location = new System.Drawing.Point(280, 85);
            this.Welcome2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome2.Name = "Welcome2";
            this.Welcome2.Size = new System.Drawing.Size(666, 91);
            this.Welcome2.TabIndex = 1;
            this.Welcome2.Text = "MEMORY GAME";
            this.Welcome2.Visible = false;
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.DarkGray;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(436, 203);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(389, 76);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Visible = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // InsBtn
            // 
            this.InsBtn.BackColor = System.Drawing.Color.DarkGray;
            this.InsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsBtn.Location = new System.Drawing.Point(436, 327);
            this.InsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InsBtn.Name = "InsBtn";
            this.InsBtn.Size = new System.Drawing.Size(389, 76);
            this.InsBtn.TabIndex = 4;
            this.InsBtn.Text = "Instructions";
            this.InsBtn.UseVisualStyleBackColor = false;
            this.InsBtn.Visible = false;
            this.InsBtn.Click += new System.EventHandler(this.InsBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(436, 443);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(389, 76);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Visible = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitMainBtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Play The Classic Memory Game!";
            // 
            // Welcome1
            // 
            this.Welcome1.AutoSize = true;
            this.Welcome1.BackColor = System.Drawing.Color.Transparent;
            this.Welcome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome1.ForeColor = System.Drawing.Color.Yellow;
            this.Welcome1.Location = new System.Drawing.Point(411, 25);
            this.Welcome1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome1.Name = "Welcome1";
            this.Welcome1.Size = new System.Drawing.Size(414, 39);
            this.Welcome1.TabIndex = 6;
            this.Welcome1.Text = "Welcome To A Revamped";
            this.Welcome1.Visible = false;
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.BackColor = System.Drawing.Color.Transparent;
            this.Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit.ForeColor = System.Drawing.Color.DarkGray;
            this.Credit.Location = new System.Drawing.Point(524, 567);
            this.Credit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(637, 25);
            this.Credit.TabIndex = 7;
            this.Credit.Text = "A RoyalDragon12 Production, In Association With Luong Gia Bao";
            // 
            // ChooseModeLabel
            // 
            this.ChooseModeLabel.AutoSize = true;
            this.ChooseModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChooseModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseModeLabel.ForeColor = System.Drawing.Color.Lime;
            this.ChooseModeLabel.Location = new System.Drawing.Point(329, 11);
            this.ChooseModeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseModeLabel.Name = "ChooseModeLabel";
            this.ChooseModeLabel.Size = new System.Drawing.Size(573, 69);
            this.ChooseModeLabel.TabIndex = 8;
            this.ChooseModeLabel.Text = "CHOOSE A MODE:";
            // 
            // ClassicBtn
            // 
            this.ClassicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassicBtn.Location = new System.Drawing.Point(436, 127);
            this.ClassicBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClassicBtn.Name = "ClassicBtn";
            this.ClassicBtn.Size = new System.Drawing.Size(389, 81);
            this.ClassicBtn.TabIndex = 9;
            this.ClassicBtn.Text = "Classic";
            this.ClassicBtn.UseVisualStyleBackColor = true;
            this.ClassicBtn.Click += new System.EventHandler(this.ClassicBtn_Click);
            // 
            // ModeBackBtn
            // 
            this.ModeBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModeBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeBackBtn.Location = new System.Drawing.Point(436, 466);
            this.ModeBackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModeBackBtn.Name = "ModeBackBtn";
            this.ModeBackBtn.Size = new System.Drawing.Size(389, 81);
            this.ModeBackBtn.TabIndex = 11;
            this.ModeBackBtn.Text = "Back";
            this.ModeBackBtn.UseVisualStyleBackColor = true;
            this.ModeBackBtn.Click += new System.EventHandler(this.ModeBackBtn_Click);
            // 
            // AiurBtn
            // 
            this.AiurBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AiurBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiurBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AiurBtn.Location = new System.Drawing.Point(436, 127);
            this.AiurBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AiurBtn.Name = "AiurBtn";
            this.AiurBtn.Size = new System.Drawing.Size(389, 81);
            this.AiurBtn.TabIndex = 12;
            this.AiurBtn.Text = "For Aiur";
            this.AiurBtn.UseVisualStyleBackColor = true;
            this.AiurBtn.Click += new System.EventHandler(this.AiurBtn_Click);
            // 
            // ThemeBackBtn
            // 
            this.ThemeBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThemeBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeBackBtn.Location = new System.Drawing.Point(436, 466);
            this.ThemeBackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThemeBackBtn.Name = "ThemeBackBtn";
            this.ThemeBackBtn.Size = new System.Drawing.Size(389, 81);
            this.ThemeBackBtn.TabIndex = 13;
            this.ThemeBackBtn.Text = "Back";
            this.ThemeBackBtn.UseVisualStyleBackColor = true;
            this.ThemeBackBtn.Click += new System.EventHandler(this.ThemeBackBtn_Click);
            // 
            // ChooseThemeLabel
            // 
            this.ChooseThemeLabel.AutoSize = true;
            this.ChooseThemeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChooseThemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseThemeLabel.ForeColor = System.Drawing.Color.Lime;
            this.ChooseThemeLabel.Location = new System.Drawing.Point(329, 11);
            this.ChooseThemeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseThemeLabel.Name = "ChooseThemeLabel";
            this.ChooseThemeLabel.Size = new System.Drawing.Size(604, 69);
            this.ChooseThemeLabel.TabIndex = 14;
            this.ChooseThemeLabel.Text = "CHOOSE A THEME:";
            // 
            // FirstPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.BackgroundImage;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(1248, 603);
            this.Controls.Add(this.ChooseThemeLabel);
            this.Controls.Add(this.ThemeBackBtn);
            this.Controls.Add(this.AiurBtn);
            this.Controls.Add(this.ModeBackBtn);
            this.Controls.Add(this.ClassicBtn);
            this.Controls.Add(this.ChooseModeLabel);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.Welcome1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.InsBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.Welcome2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FirstPanel";
            this.Opacity = 100;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Long Live The Memory Game!";
            this.Shown += new System.EventHandler(this.FirstPanel_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Welcome2;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button InsBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Welcome1;
        private System.Windows.Forms.Label Credit;
        private System.Windows.Forms.Label ChooseModeLabel;
        private System.Windows.Forms.Button ClassicBtn;
        private System.Windows.Forms.Button ModeBackBtn;
        private System.Windows.Forms.Button AiurBtn;
        private System.Windows.Forms.Button ThemeBackBtn;
        private System.Windows.Forms.Label ChooseThemeLabel;
    }
}

