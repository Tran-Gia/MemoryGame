namespace WindowsFormsApplication1
{
    partial class AbilitiesDialog
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
            this.SolarPanelsBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SolarPanelsManaLabel = new System.Windows.Forms.Label();
            this.SolarPanelsLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InstantPairLabel = new System.Windows.Forms.Label();
            this.InstantPairManaLabel = new System.Windows.Forms.Label();
            this.InstantPairBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReveal
            // 
            this.SolarPanelsBtn.Location = new System.Drawing.Point(6, 19);
            this.SolarPanelsBtn.Name = "SolarPanelsBtn";
            this.SolarPanelsBtn.Size = new System.Drawing.Size(102, 68);
            this.SolarPanelsBtn.TabIndex = 1;
            this.SolarPanelsBtn.Text = "Solar Panels";
            this.SolarPanelsBtn.UseVisualStyleBackColor = true;
            this.SolarPanelsBtn.Click += new System.EventHandler(this.SolarPanelsBtn_Click);
            // 
            // btnCancel
            // 
            this.CancelBtn.Location = new System.Drawing.Point(12, 220);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(430, 29);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SolarPanelsLabel);
            this.groupBox1.Controls.Add(this.SolarPanelsManaLabel);
            this.groupBox1.Controls.Add(this.SolarPanelsBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblManaCost
            // 
            this.SolarPanelsManaLabel.AutoSize = true;
            this.SolarPanelsManaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolarPanelsManaLabel.Location = new System.Drawing.Point(114, 19);
            this.SolarPanelsManaLabel.Name = "SolarPanelsManaLabel";
            this.SolarPanelsManaLabel.Size = new System.Drawing.Size(121, 20);
            this.SolarPanelsManaLabel.TabIndex = 2;
            this.SolarPanelsManaLabel.Text = "Mana Cost: 500";
            // 
            // lblDesc
            // 
            this.SolarPanelsLabel.AutoSize = true;
            this.SolarPanelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolarPanelsLabel.Location = new System.Drawing.Point(114, 42);
            this.SolarPanelsLabel.Name = "SolarPanelsLabel";
            this.SolarPanelsLabel.Size = new System.Drawing.Size(286, 40);
            this.SolarPanelsLabel.TabIndex = 3;
            this.SolarPanelsLabel.Text = "Reveal all images for 1.5 seconds. You \r\ncannot match any pair during this time.\r" +
    "\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InstantPairLabel);
            this.groupBox2.Controls.Add(this.InstantPairManaLabel);
            this.groupBox2.Controls.Add(this.InstantPairBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 99);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // lblDesc2
            // 
            this.InstantPairLabel.AutoSize = true;
            this.InstantPairLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstantPairLabel.Location = new System.Drawing.Point(114, 42);
            this.InstantPairLabel.Name = "InstantPairLabel";
            this.InstantPairLabel.Size = new System.Drawing.Size(245, 20);
            this.InstantPairLabel.TabIndex = 3;
            this.InstantPairLabel.Text = "Instantly completes a pair.";
            // 
            // lblManaCost2
            // 
            this.InstantPairManaLabel.AutoSize = true;
            this.InstantPairManaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstantPairManaLabel.Location = new System.Drawing.Point(114, 19);
            this.InstantPairManaLabel.Name = "InstantPairManaLabel";
            this.InstantPairManaLabel.Size = new System.Drawing.Size(121, 20);
            this.InstantPairManaLabel.TabIndex = 2;
            this.InstantPairManaLabel.Text = "Mana Cost: 200";
            // 
            // btnInstantPair
            // 
            this.InstantPairBtn.Location = new System.Drawing.Point(6, 19);
            this.InstantPairBtn.Name = "InstantPairBtn";
            this.InstantPairBtn.Size = new System.Drawing.Size(102, 68);
            this.InstantPairBtn.TabIndex = 1;
            this.InstantPairBtn.Text = "Instant Pair";
            this.InstantPairBtn.UseVisualStyleBackColor = true;
            this.InstantPairBtn.Click += new System.EventHandler(this.InstantPairBtn_Click);
            // 
            // PowerSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 256);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PowerSkill";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SolarPanelsBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SolarPanelsLabel;
        private System.Windows.Forms.Label SolarPanelsManaLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label InstantPairLabel;
        private System.Windows.Forms.Label InstantPairManaLabel;
        private System.Windows.Forms.Button InstantPairBtn;
    }
}