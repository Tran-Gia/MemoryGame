﻿namespace WindowsFormsApplication1
{
    partial class RacePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacePanel));
            this.RaceBtnZ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RaceBtnZ
            // 
            this.RaceBtnZ.Location = new System.Drawing.Point(35, 95);
            this.RaceBtnZ.Name = "RaceBtnZ";
            this.RaceBtnZ.Size = new System.Drawing.Size(150, 150);
            this.RaceBtnZ.TabIndex = 0;
            this.RaceBtnZ.Text = "RaceBtnZ";
            this.RaceBtnZ.UseVisualStyleBackColor = true;
            // 
            // RacePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 335);
            this.Controls.Add(this.RaceBtnZ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RacePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RacePanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RaceBtnZ;
    }
}