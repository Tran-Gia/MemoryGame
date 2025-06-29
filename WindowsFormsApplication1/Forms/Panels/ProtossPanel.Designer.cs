namespace WindowsFormsApplication1
{
    partial class ProtossPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtossPanel));
            this.PanelTimer = new System.Windows.Forms.Timer(this.components);
            this.GameStartBtn = new System.Windows.Forms.Button();
            this.RemainingTimeProBar = new System.Windows.Forms.ProgressBar();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ComboInfoLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Combolbl = new System.Windows.Forms.Label();
            this.AbilitiesBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.AvatarPicBox = new System.Windows.Forms.PictureBox();
            this.EnergyProBar = new WindowsFormsApplication1.NewProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTimer
            // 
            this.PanelTimer.Tick += new System.EventHandler(this.PanelTimer_Tick);
            // 
            // GameStartBtn
            // 
            this.GameStartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GameStartBtn.BackColor = System.Drawing.Color.Navy;
            this.GameStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GameStartBtn.Location = new System.Drawing.Point(12, 548);
            this.GameStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GameStartBtn.Name = "GameStartBtn";
            this.GameStartBtn.Size = new System.Drawing.Size(206, 108);
            this.GameStartBtn.TabIndex = 0;
            this.GameStartBtn.Text = "START";
            this.GameStartBtn.UseVisualStyleBackColor = false;
            this.GameStartBtn.Click += new System.EventHandler(this.GameStartBtn_Click);
            // 
            // RemainingTimeProBar
            // 
            this.RemainingTimeProBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemainingTimeProBar.BackColor = System.Drawing.Color.White;
            this.RemainingTimeProBar.ForeColor = System.Drawing.Color.Transparent;
            this.RemainingTimeProBar.Location = new System.Drawing.Point(226, 508);
            this.RemainingTimeProBar.Margin = new System.Windows.Forms.Padding(4);
            this.RemainingTimeProBar.Name = "RemainingTimeProBar";
            this.RemainingTimeProBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RemainingTimeProBar.Size = new System.Drawing.Size(611, 70);
            this.RemainingTimeProBar.Step = -1;
            this.RemainingTimeProBar.TabIndex = 4;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.BackColor = System.Drawing.Color.White;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeLabel.Location = new System.Drawing.Point(474, 528);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(87, 31);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "00:00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboInfoLabel
            // 
            this.ComboInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboInfoLabel.AutoSize = true;
            this.ComboInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ComboInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboInfoLabel.ForeColor = System.Drawing.Color.Blue;
            this.ComboInfoLabel.Location = new System.Drawing.Point(13, 465);
            this.ComboInfoLabel.Margin = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.ComboInfoLabel.Name = "ComboInfoLabel";
            this.ComboInfoLabel.Size = new System.Drawing.Size(142, 36);
            this.ComboInfoLabel.TabIndex = 6;
            this.ComboInfoLabel.Text = "Combo:  ";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.White;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(13, 508);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(206, 36);
            this.ScoreLabel.TabIndex = 8;
            this.ScoreLabel.Text = "Score: 00000";
            // 
            // Combolbl
            // 
            this.Combolbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Combolbl.AutoSize = true;
            this.Combolbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Combolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combolbl.ForeColor = System.Drawing.Color.Red;
            this.Combolbl.Location = new System.Drawing.Point(145, 465);
            this.Combolbl.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Combolbl.Name = "Combolbl";
            this.Combolbl.Size = new System.Drawing.Size(73, 36);
            this.Combolbl.TabIndex = 10;
            this.Combolbl.Text = "00X";
            // 
            // AbilitiesBtn
            // 
            this.AbilitiesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilitiesBtn.BackColor = System.Drawing.Color.Yellow;
            this.AbilitiesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbilitiesBtn.Enabled = false;
            this.AbilitiesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbilitiesBtn.ForeColor = System.Drawing.Color.Red;
            this.AbilitiesBtn.Location = new System.Drawing.Point(845, 371);
            this.AbilitiesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AbilitiesBtn.Name = "AbilitiesBtn";
            this.AbilitiesBtn.Size = new System.Drawing.Size(200, 77);
            this.AbilitiesBtn.TabIndex = 11;
            this.AbilitiesBtn.Text = "ABILITIES";
            this.AbilitiesBtn.UseVisualStyleBackColor = false;
            this.AbilitiesBtn.Click += new System.EventHandler(this.PowerUpBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuBtn.BackColor = System.Drawing.Color.DimGray;
            this.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MenuBtn.Location = new System.Drawing.Point(13, 371);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(206, 90);
            this.MenuBtn.TabIndex = 12;
            this.MenuBtn.Text = "MENU";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // AvatarPicBox
            // 
            this.AvatarPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AvatarPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvatarPicBox.Image = global::WindowsFormsApplication1.Properties.Resources.Fenix;
            this.AvatarPicBox.Location = new System.Drawing.Point(845, 456);
            this.AvatarPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.AvatarPicBox.MaximumSize = new System.Drawing.Size(200, 200);
            this.AvatarPicBox.Name = "AvatarPicBox";
            this.AvatarPicBox.Size = new System.Drawing.Size(200, 200);
            this.AvatarPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarPicBox.TabIndex = 1;
            this.AvatarPicBox.TabStop = false;
            // 
            // EnergyProBar
            // 
            this.EnergyProBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnergyProBar.Location = new System.Drawing.Point(226, 586);
            this.EnergyProBar.Margin = new System.Windows.Forms.Padding(4);
            this.EnergyProBar.Maximum = 1000;
            this.EnergyProBar.Name = "EnergyProBar";
            this.EnergyProBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EnergyProBar.Size = new System.Drawing.Size(611, 70);
            this.EnergyProBar.Step = 5;
            this.EnergyProBar.TabIndex = 13;
            // 
            // ProtossPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1058, 669);
            this.Controls.Add(this.Combolbl);
            this.Controls.Add(this.ComboInfoLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameStartBtn);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.EnergyProBar);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.AbilitiesBtn);
            this.Controls.Add(this.RemainingTimeProBar);
            this.Controls.Add(this.AvatarPicBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProtossPanel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 1";
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication1.NewProgressBar EnergyProBar;
        private System.Windows.Forms.Timer PanelTimer;
        private System.Windows.Forms.Button GameStartBtn;
        private System.Windows.Forms.PictureBox AvatarPicBox;
        private System.Windows.Forms.ProgressBar RemainingTimeProBar;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label ComboInfoLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label Combolbl;
        private System.Windows.Forms.Button AbilitiesBtn;
        private System.Windows.Forms.Button MenuBtn;
    }
}