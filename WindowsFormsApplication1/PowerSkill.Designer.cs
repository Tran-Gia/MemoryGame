namespace WindowsFormsApplication1
{
    partial class PowerSkill
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
            this.btnReveal = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblManaCost = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.lblManaCost2 = new System.Windows.Forms.Label();
            this.btnInstantPair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReveal
            // 
            this.btnReveal.Location = new System.Drawing.Point(6, 19);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(102, 68);
            this.btnReveal.TabIndex = 1;
            this.btnReveal.Text = "Reveal Image";
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.RevealBtn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(430, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Controls.Add(this.lblManaCost);
            this.groupBox1.Controls.Add(this.btnReveal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblManaCost
            // 
            this.lblManaCost.AutoSize = true;
            this.lblManaCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManaCost.Location = new System.Drawing.Point(114, 19);
            this.lblManaCost.Name = "lblManaCost";
            this.lblManaCost.Size = new System.Drawing.Size(121, 20);
            this.lblManaCost.TabIndex = 2;
            this.lblManaCost.Text = "Mana Cost: 500";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(114, 42);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(286, 40);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Reveal all images for 1.5 seconds. You \r\ncannot match any pair during this time.\r" +
    "\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDesc2);
            this.groupBox2.Controls.Add(this.lblManaCost2);
            this.groupBox2.Controls.Add(this.btnInstantPair);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 99);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc2.Location = new System.Drawing.Point(114, 42);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(245, 20);
            this.lblDesc2.TabIndex = 3;
            this.lblDesc2.Text = "Instantly completes a pair for you.";
            // 
            // lblManaCost2
            // 
            this.lblManaCost2.AutoSize = true;
            this.lblManaCost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManaCost2.Location = new System.Drawing.Point(114, 19);
            this.lblManaCost2.Name = "lblManaCost2";
            this.lblManaCost2.Size = new System.Drawing.Size(121, 20);
            this.lblManaCost2.TabIndex = 2;
            this.lblManaCost2.Text = "Mana Cost: 200";
            // 
            // btnInstantPair
            // 
            this.btnInstantPair.Location = new System.Drawing.Point(6, 19);
            this.btnInstantPair.Name = "btnInstantPair";
            this.btnInstantPair.Size = new System.Drawing.Size(102, 68);
            this.btnInstantPair.TabIndex = 1;
            this.btnInstantPair.Text = "Instant Pair";
            this.btnInstantPair.UseVisualStyleBackColor = true;
            this.btnInstantPair.Click += new System.EventHandler(this.BtnInstantPair_Click);
            // 
            // PowerSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 256);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
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

        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblManaCost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDesc2;
        private System.Windows.Forms.Label lblManaCost2;
        private System.Windows.Forms.Button btnInstantPair;
    }
}