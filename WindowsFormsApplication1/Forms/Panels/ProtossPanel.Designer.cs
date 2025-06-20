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
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameStartBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ComboInfoLabel = new System.Windows.Forms.Label();
            this.ScoreDisplaylbl = new System.Windows.Forms.Label();
            this.PlayerScorelbl = new System.Windows.Forms.Label();
            this.Combolbl = new System.Windows.Forms.Label();
            this.PowerUpBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.manaProgressBar = new WindowsFormsApplication1.NewProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GameStartBtn
            // 
            this.GameStartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GameStartBtn.BackColor = System.Drawing.Color.Navy;
            this.GameStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GameStartBtn.Location = new System.Drawing.Point(843, 171);
            this.GameStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GameStartBtn.Name = "GameStartBtn";
            this.GameStartBtn.Size = new System.Drawing.Size(200, 85);
            this.GameStartBtn.TabIndex = 0;
            this.GameStartBtn.Text = "START";
            this.GameStartBtn.UseVisualStyleBackColor = false;
            this.GameStartBtn.Click += new System.EventHandler(this.GameStartBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.Location = new System.Drawing.Point(204, 508);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(633, 70);
            this.progressBar1.TabIndex = 4;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
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
            this.ComboInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboInfoLabel.AutoSize = true;
            this.ComboInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ComboInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboInfoLabel.ForeColor = System.Drawing.Color.Blue;
            this.ComboInfoLabel.Location = new System.Drawing.Point(843, 260);
            this.ComboInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComboInfoLabel.Name = "ComboInfoLabel";
            this.ComboInfoLabel.Size = new System.Drawing.Size(187, 36);
            this.ComboInfoLabel.TabIndex = 6;
            this.ComboInfoLabel.Text = "Combo:       ";
            // 
            // ScoreDisplaylbl
            // 
            this.ScoreDisplaylbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreDisplaylbl.AutoSize = true;
            this.ScoreDisplaylbl.BackColor = System.Drawing.Color.White;
            this.ScoreDisplaylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreDisplaylbl.Location = new System.Drawing.Point(843, 308);
            this.ScoreDisplaylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreDisplaylbl.Name = "ScoreDisplaylbl";
            this.ScoreDisplaylbl.Size = new System.Drawing.Size(188, 36);
            this.ScoreDisplaylbl.TabIndex = 8;
            this.ScoreDisplaylbl.Text = "Score:         ";
            // 
            // PlayerScorelbl
            // 
            this.PlayerScorelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerScorelbl.AutoSize = true;
            this.PlayerScorelbl.BackColor = System.Drawing.Color.White;
            this.PlayerScorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScorelbl.Location = new System.Drawing.Point(960, 308);
            this.PlayerScorelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerScorelbl.Name = "PlayerScorelbl";
            this.PlayerScorelbl.Size = new System.Drawing.Size(83, 36);
            this.PlayerScorelbl.TabIndex = 9;
            this.PlayerScorelbl.Text = "0000";
            // 
            // Combolbl
            // 
            this.Combolbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Combolbl.AutoSize = true;
            this.Combolbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Combolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combolbl.ForeColor = System.Drawing.Color.Red;
            this.Combolbl.Location = new System.Drawing.Point(990, 260);
            this.Combolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Combolbl.Name = "Combolbl";
            this.Combolbl.Size = new System.Drawing.Size(55, 36);
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
            this.PowerUpBtn.Location = new System.Drawing.Point(13, 508);
            this.PowerUpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PowerUpBtn.Name = "PowerUpBtn";
            this.PowerUpBtn.Size = new System.Drawing.Size(183, 148);
            this.PowerUpBtn.TabIndex = 11;
            this.PowerUpBtn.Text = "POWER UP";
            this.PowerUpBtn.UseVisualStyleBackColor = false;
            this.PowerUpBtn.Click += new System.EventHandler(this.PowerUpBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuBtn.BackColor = System.Drawing.Color.DimGray;
            this.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MenuBtn.Location = new System.Drawing.Point(845, 358);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(200, 90);
            this.MenuBtn.TabIndex = 12;
            this.MenuBtn.Text = "MENU";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Fenix;
            this.pictureBox1.Location = new System.Drawing.Point(845, 456);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(200, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // manaProgressBar
            // 
            this.manaProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manaProgressBar.Location = new System.Drawing.Point(204, 586);
            this.manaProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.manaProgressBar.Name = "manaProgressBar";
            this.manaProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manaProgressBar.Size = new System.Drawing.Size(633, 70);
            this.manaProgressBar.TabIndex = 13;
            // 
            // ProtossPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 669);
            this.Controls.Add(this.GameStartBtn);
            this.Controls.Add(this.Combolbl);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.ComboInfoLabel);
            this.Controls.Add(this.manaProgressBar);
            this.Controls.Add(this.PlayerScorelbl);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.PowerUpBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ScoreDisplaylbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProtossPanel";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication1.NewProgressBar manaProgressBar;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Button GameStartBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label ComboInfoLabel;
        private System.Windows.Forms.Label ScoreDisplaylbl;
        private System.Windows.Forms.Label PlayerScorelbl;
        private System.Windows.Forms.Label Combolbl;
        private System.Windows.Forms.Button PowerUpBtn;
        private System.Windows.Forms.Button MenuBtn;
    }
}