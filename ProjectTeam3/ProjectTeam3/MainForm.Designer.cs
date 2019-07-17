namespace ProjectTeam3
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPackageCount = new System.Windows.Forms.TextBox();
            this.txtMinDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxBasePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinBasePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Travel Experts - Travel Packages Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total number of Packages:";
            // 
            // txtPackageCount
            // 
            this.txtPackageCount.Enabled = false;
            this.txtPackageCount.Location = new System.Drawing.Point(171, 61);
            this.txtPackageCount.Name = "txtPackageCount";
            this.txtPackageCount.Size = new System.Drawing.Size(69, 20);
            this.txtPackageCount.TabIndex = 2;
            // 
            // txtMinDuration
            // 
            this.txtMinDuration.Enabled = false;
            this.txtMinDuration.Location = new System.Drawing.Point(171, 87);
            this.txtMinDuration.Name = "txtMinDuration";
            this.txtMinDuration.Size = new System.Drawing.Size(69, 20);
            this.txtMinDuration.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Minumum duration (Days):";
            // 
            // txtMaxDuration
            // 
            this.txtMaxDuration.Enabled = false;
            this.txtMaxDuration.Location = new System.Drawing.Point(404, 87);
            this.txtMaxDuration.Name = "txtMaxDuration";
            this.txtMaxDuration.Size = new System.Drawing.Size(69, 20);
            this.txtMaxDuration.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Maximun duration (Days):";
            // 
            // txtMaxBasePrice
            // 
            this.txtMaxBasePrice.Enabled = false;
            this.txtMaxBasePrice.Location = new System.Drawing.Point(404, 113);
            this.txtMaxBasePrice.Name = "txtMaxBasePrice";
            this.txtMaxBasePrice.Size = new System.Drawing.Size(69, 20);
            this.txtMaxBasePrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Highest Base Price";
            // 
            // txtMinBasePrice
            // 
            this.txtMinBasePrice.Enabled = false;
            this.txtMinBasePrice.Location = new System.Drawing.Point(171, 113);
            this.txtMinBasePrice.Name = "txtMinBasePrice";
            this.txtMinBasePrice.Size = new System.Drawing.Size(69, 20);
            this.txtMinBasePrice.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lowest Base Price:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMaxBasePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMinBasePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPackageCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "TravelExperts Travel Packages Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPackageCount;
        private System.Windows.Forms.TextBox txtMinDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxBasePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinBasePrice;
        private System.Windows.Forms.Label label6;
    }
}

