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
            this.BackMenuBtn = new System.Windows.Forms.Button();
            this.SoundBtn = new System.Windows.Forms.Button();
            this.ExitToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MusicBtn
            // 
            this.MusicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicBtn.Location = new System.Drawing.Point(12, 12);
            this.MusicBtn.Name = "MusicBtn";
            this.MusicBtn.Size = new System.Drawing.Size(205, 35);
            this.MusicBtn.TabIndex = 9;
            this.MusicBtn.Text = "Music: ON";
            this.MusicBtn.UseVisualStyleBackColor = true;
            this.MusicBtn.Click += new System.EventHandler(this.MusicBtn_Click);
            // 
            // ExitGameBtn
            // 
            this.ExitGameBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitGameBtn.Location = new System.Drawing.Point(12, 135);
            this.ExitGameBtn.Name = "ExitGameBtn";
            this.ExitGameBtn.Size = new System.Drawing.Size(205, 35);
            this.ExitGameBtn.TabIndex = 8;
            this.ExitGameBtn.Text = "Exit Game";
            this.ExitGameBtn.UseVisualStyleBackColor = true;
            this.ExitGameBtn.Click += new System.EventHandler(this.ExitGameBtn_Click);
            // 
            // BackMenuBtn
            // 
            this.BackMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMenuBtn.Location = new System.Drawing.Point(12, 176);
            this.BackMenuBtn.Name = "BackMenuBtn";
            this.BackMenuBtn.Size = new System.Drawing.Size(205, 35);
            this.BackMenuBtn.TabIndex = 7;
            this.BackMenuBtn.Text = "Cancel";
            this.BackMenuBtn.UseVisualStyleBackColor = true;
            this.BackMenuBtn.Click += new System.EventHandler(this.BackMenuBtn_Click);
            // 
            // SoundBtn
            // 
            this.SoundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoundBtn.Location = new System.Drawing.Point(12, 53);
            this.SoundBtn.Name = "SoundBtn";
            this.SoundBtn.Size = new System.Drawing.Size(205, 35);
            this.SoundBtn.TabIndex = 6;
            this.SoundBtn.Text = "Sound: ON";
            this.SoundBtn.UseVisualStyleBackColor = true;
            this.SoundBtn.Click += new System.EventHandler(this.SoundBtn_Click);
            // 
            // ExitToMenuBtn
            // 
            this.ExitToMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToMenuBtn.Location = new System.Drawing.Point(12, 94);
            this.ExitToMenuBtn.Name = "ExitToMenuBtn";
            this.ExitToMenuBtn.Size = new System.Drawing.Size(205, 35);
            this.ExitToMenuBtn.TabIndex = 5;
            this.ExitToMenuBtn.Text = "Exit To Menu";
            this.ExitToMenuBtn.UseVisualStyleBackColor = true;
            this.ExitToMenuBtn.Click += new System.EventHandler(this.ExitToMenuBtn_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 220);
            this.ControlBox = false;
            this.Controls.Add(this.MusicBtn);
            this.Controls.Add(this.ExitGameBtn);
            this.Controls.Add(this.BackMenuBtn);
            this.Controls.Add(this.SoundBtn);
            this.Controls.Add(this.ExitToMenuBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button BackMenuBtn;
        private System.Windows.Forms.Button SoundBtn;
        private System.Windows.Forms.Button ExitToMenuBtn;
    }
}