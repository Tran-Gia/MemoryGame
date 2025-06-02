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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameStartBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AvatarNameLabel = new System.Windows.Forms.Label();
            this.TimeInfoLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ComboInfoLabel = new System.Windows.Forms.Label();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ScoreDisplaylbl = new System.Windows.Forms.Label();
            this.PlayerScorelbl = new System.Windows.Forms.Label();
            this.Combolbl = new System.Windows.Forms.Label();
            this.PowerUpBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manaProgressBar = new WindowsFormsApplication1.NewProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameStartBtn
            // 
            this.GameStartBtn.Location = new System.Drawing.Point(28, 244);
            this.GameStartBtn.Name = "GameStartBtn";
            this.GameStartBtn.Size = new System.Drawing.Size(71, 40);
            this.GameStartBtn.TabIndex = 0;
            this.GameStartBtn.Text = "Start";
            this.GameStartBtn.UseVisualStyleBackColor = true;
            this.GameStartBtn.Click += new System.EventHandler(this.GameStartBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Protoss_Image_Icon_Khalai;
            this.pictureBox1.Location = new System.Drawing.Point(28, 23);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(150, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AvatarNameLabel
            // 
            this.AvatarNameLabel.AutoSize = true;
            this.AvatarNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.AvatarNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvatarNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvatarNameLabel.ForeColor = System.Drawing.Color.Blue;
            this.AvatarNameLabel.Location = new System.Drawing.Point(31, 186);
            this.AvatarNameLabel.Name = "AvatarNameLabel";
            this.AvatarNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AvatarNameLabel.Size = new System.Drawing.Size(132, 31);
            this.AvatarNameLabel.TabIndex = 2;
            this.AvatarNameLabel.Text = "   KHALAI";
            this.AvatarNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeInfoLabel
            // 
            this.TimeInfoLabel.AutoSize = true;
            this.TimeInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TimeInfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInfoLabel.Location = new System.Drawing.Point(29, 291);
            this.TimeInfoLabel.Name = "TimeInfoLabel";
            this.TimeInfoLabel.Size = new System.Drawing.Size(149, 31);
            this.TimeInfoLabel.TabIndex = 3;
            this.TimeInfoLabel.Text = "Times Left:";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.Location = new System.Drawing.Point(28, 330);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(152, 44);
            this.progressBar1.TabIndex = 4;
            // 
            // manaProgressBar
            // 
            this.manaProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manaProgressBar.Location = new System.Drawing.Point(114, 482);
            this.manaProgressBar.Name = "manaProgressBar";
            this.manaProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manaProgressBar.Size = new System.Drawing.Size(649, 44);
            this.manaProgressBar.TabIndex = 13;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeLabel.Location = new System.Drawing.Point(71, 339);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(71, 25);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "00:00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboInfoLabel
            // 
            this.ComboInfoLabel.AutoSize = true;
            this.ComboInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ComboInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboInfoLabel.ForeColor = System.Drawing.Color.Blue;
            this.ComboInfoLabel.Location = new System.Drawing.Point(28, 384);
            this.ComboInfoLabel.Name = "ComboInfoLabel";
            this.ComboInfoLabel.Size = new System.Drawing.Size(153, 29);
            this.ComboInfoLabel.TabIndex = 6;
            this.ComboInfoLabel.Text = "Combo:       ";
            // 
            // PauseBtn
            // 
            this.PauseBtn.Location = new System.Drawing.Point(110, 244);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(71, 40);
            this.PauseBtn.TabIndex = 7;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // ScoreDisplaylbl
            // 
            this.ScoreDisplaylbl.AutoSize = true;
            this.ScoreDisplaylbl.BackColor = System.Drawing.Color.White;
            this.ScoreDisplaylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreDisplaylbl.Location = new System.Drawing.Point(28, 423);
            this.ScoreDisplaylbl.Name = "ScoreDisplaylbl";
            this.ScoreDisplaylbl.Size = new System.Drawing.Size(152, 29);
            this.ScoreDisplaylbl.TabIndex = 8;
            this.ScoreDisplaylbl.Text = "Score:         ";
            // 
            // PlayerScorelbl
            // 
            this.PlayerScorelbl.AutoSize = true;
            this.PlayerScorelbl.BackColor = System.Drawing.Color.White;
            this.PlayerScorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScorelbl.Location = new System.Drawing.Point(116, 423);
            this.PlayerScorelbl.Name = "PlayerScorelbl";
            this.PlayerScorelbl.Size = new System.Drawing.Size(65, 29);
            this.PlayerScorelbl.TabIndex = 9;
            this.PlayerScorelbl.Text = "0000";
            // 
            // Combolbl
            // 
            this.Combolbl.AutoSize = true;
            this.Combolbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Combolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combolbl.ForeColor = System.Drawing.Color.Red;
            this.Combolbl.Location = new System.Drawing.Point(135, 384);
            this.Combolbl.Name = "Combolbl";
            this.Combolbl.Size = new System.Drawing.Size(45, 29);
            this.Combolbl.TabIndex = 10;
            this.Combolbl.Text = "1X";
            // 
            // PowerUpBtn
            // 
            this.PowerUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PowerUpBtn.BackColor = System.Drawing.Color.Yellow;
            this.PowerUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerUpBtn.ForeColor = System.Drawing.Color.Red;
            this.PowerUpBtn.Location = new System.Drawing.Point(-1, 482);
            this.PowerUpBtn.Name = "PowerUpBtn";
            this.PowerUpBtn.Size = new System.Drawing.Size(116, 44);
            this.PowerUpBtn.TabIndex = 11;
            this.PowerUpBtn.Text = "Power Up";
            this.PowerUpBtn.UseVisualStyleBackColor = false;
            this.PowerUpBtn.Click += new System.EventHandler(this.PowerUpBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.DimGray;
            this.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MenuBtn.Location = new System.Drawing.Point(28, 460);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(153, 68);
            this.MenuBtn.TabIndex = 12;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.MenuBtn);
            this.groupBox1.Controls.Add(this.GameStartBtn);
            this.groupBox1.Controls.Add(this.Combolbl);
            this.groupBox1.Controls.Add(this.ComboInfoLabel);
            this.groupBox1.Controls.Add(this.PlayerScorelbl);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.AvatarNameLabel);
            this.groupBox1.Controls.Add(this.TimeLabel);
            this.groupBox1.Controls.Add(this.PauseBtn);
            this.groupBox1.Controls.Add(this.TimeInfoLabel);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.ScoreDisplaylbl);
            this.groupBox1.Location = new System.Drawing.Point(762, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 539);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // ProtossPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.LoadingScreen_Protoss;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 525);
            this.Controls.Add(this.manaProgressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PowerUpBtn);
            this.DoubleBuffered = true;
            this.Name = "ProtossPanel";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsApplication1.NewProgressBar manaProgressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button GameStartBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AvatarNameLabel;
        private System.Windows.Forms.Label TimeInfoLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label ComboInfoLabel;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Label ScoreDisplaylbl;
        private System.Windows.Forms.Label PlayerScorelbl;
        private System.Windows.Forms.Label Combolbl;
        private System.Windows.Forms.Button PowerUpBtn;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}