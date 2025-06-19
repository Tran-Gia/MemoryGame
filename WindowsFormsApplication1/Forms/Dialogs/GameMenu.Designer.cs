namespace WindowsFormsApplication1
{
    partial class GameMenu
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
            this.MusicBtn = new System.Windows.Forms.Button();
            this.ExitGameBtn = new System.Windows.Forms.Button();
            this.UnpauseBtn = new System.Windows.Forms.Button();
            this.SoundBtn = new System.Windows.Forms.Button();
            this.ExitToMenuBtn = new System.Windows.Forms.Button();
            this.ResolutionBtn = new System.Windows.Forms.Button();
            this.ResolutionCboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MusicBtn
            // 
            this.MusicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicBtn.Location = new System.Drawing.Point(13, 115);
            this.MusicBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MusicBtn.Name = "MusicBtn";
            this.MusicBtn.Size = new System.Drawing.Size(335, 43);
            this.MusicBtn.TabIndex = 9;
            this.MusicBtn.Text = "Music: ON";
            this.MusicBtn.UseVisualStyleBackColor = true;
            this.MusicBtn.Click += new System.EventHandler(this.MusicBtn_Click);
            // 
            // ExitGameBtn
            // 
            this.ExitGameBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitGameBtn.Location = new System.Drawing.Point(13, 268);
            this.ExitGameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitGameBtn.Name = "ExitGameBtn";
            this.ExitGameBtn.Size = new System.Drawing.Size(335, 43);
            this.ExitGameBtn.TabIndex = 8;
            this.ExitGameBtn.Text = "Exit Game";
            this.ExitGameBtn.UseVisualStyleBackColor = true;
            this.ExitGameBtn.Click += new System.EventHandler(this.ExitGameBtn_Click);
            // 
            // UnpauseBtn
            // 
            this.UnpauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnpauseBtn.Location = new System.Drawing.Point(13, 13);
            this.UnpauseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UnpauseBtn.Name = "UnpauseBtn";
            this.UnpauseBtn.Size = new System.Drawing.Size(335, 43);
            this.UnpauseBtn.TabIndex = 7;
            this.UnpauseBtn.Text = "Unpause Game";
            this.UnpauseBtn.UseVisualStyleBackColor = true;
            this.UnpauseBtn.Click += new System.EventHandler(this.BackMenuBtn_Click);
            // 
            // SoundBtn
            // 
            this.SoundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoundBtn.Location = new System.Drawing.Point(13, 166);
            this.SoundBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SoundBtn.Name = "SoundBtn";
            this.SoundBtn.Size = new System.Drawing.Size(338, 43);
            this.SoundBtn.TabIndex = 6;
            this.SoundBtn.Text = "Unit Sound: ON";
            this.SoundBtn.UseVisualStyleBackColor = true;
            this.SoundBtn.Click += new System.EventHandler(this.SoundBtn_Click);
            // 
            // ExitToMenuBtn
            // 
            this.ExitToMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToMenuBtn.Location = new System.Drawing.Point(13, 217);
            this.ExitToMenuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitToMenuBtn.Name = "ExitToMenuBtn";
            this.ExitToMenuBtn.Size = new System.Drawing.Size(338, 43);
            this.ExitToMenuBtn.TabIndex = 5;
            this.ExitToMenuBtn.Text = "Exit To Menu";
            this.ExitToMenuBtn.UseVisualStyleBackColor = true;
            this.ExitToMenuBtn.Click += new System.EventHandler(this.ExitToMenuBtn_Click);
            // 
            // ResolutionBtn
            // 
            this.ResolutionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionBtn.Location = new System.Drawing.Point(13, 64);
            this.ResolutionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ResolutionBtn.Name = "ResolutionBtn";
            this.ResolutionBtn.Size = new System.Drawing.Size(335, 43);
            this.ResolutionBtn.TabIndex = 10;
            this.ResolutionBtn.Text = "Resolution: ";
            this.ResolutionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResolutionBtn.UseVisualStyleBackColor = true;
            // 
            // ResolutionCboBox
            // 
            this.ResolutionCboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionCboBox.FormattingEnabled = true;
            this.ResolutionCboBox.Location = new System.Drawing.Point(200, 69);
            this.ResolutionCboBox.Name = "ResolutionCboBox";
            this.ResolutionCboBox.Size = new System.Drawing.Size(143, 33);
            this.ResolutionCboBox.TabIndex = 11;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 315);
            this.ControlBox = false;
            this.Controls.Add(this.ResolutionCboBox);
            this.Controls.Add(this.ResolutionBtn);
            this.Controls.Add(this.MusicBtn);
            this.Controls.Add(this.ExitGameBtn);
            this.Controls.Add(this.UnpauseBtn);
            this.Controls.Add(this.SoundBtn);
            this.Controls.Add(this.ExitToMenuBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MusicBtn;
        private System.Windows.Forms.Button ExitGameBtn;
        private System.Windows.Forms.Button UnpauseBtn;
        private System.Windows.Forms.Button SoundBtn;
        private System.Windows.Forms.Button ExitToMenuBtn;
        private System.Windows.Forms.Button ResolutionBtn;
        private System.Windows.Forms.ComboBox ResolutionCboBox;
    }
}