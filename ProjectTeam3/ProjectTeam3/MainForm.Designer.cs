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
            this.btnPackages = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPackageCount = new System.Windows.Forms.TextBox();
            this.txtTotalNumProducts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinDuration = new System.Windows.Forms.TextBox();
            this.txtEngagedProducts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaxDuration = new System.Windows.Forms.TextBox();
            this.txtTotalNumSuppliers = new System.Windows.Forms.TextBox();
            this.lblCostMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinBasePrice = new System.Windows.Forms.TextBox();
            this.txtEngagedSuppliers = new System.Windows.Forms.TextBox();
            this.lblCostMax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxBasePrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPackages
            // 
            this.btnPackages.Location = new System.Drawing.Point(22, 226);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(105, 38);
            this.btnPackages.TabIndex = 11;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = true;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(479, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "Include Agency Commission";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(369, 25);
            this.label10.TabIndex = 51;
            this.label10.Text = "Packages Summary and Overview";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Total Number of Packages:";
            // 
            // txtPackageCount
            // 
            this.txtPackageCount.Enabled = false;
            this.txtPackageCount.Location = new System.Drawing.Point(161, 80);
            this.txtPackageCount.Name = "txtPackageCount";
            this.txtPackageCount.Size = new System.Drawing.Size(69, 20);
            this.txtPackageCount.TabIndex = 34;
            // 
            // txtTotalNumProducts
            // 
            this.txtTotalNumProducts.Enabled = false;
            this.txtTotalNumProducts.Location = new System.Drawing.Point(394, 184);
            this.txtTotalNumProducts.Name = "txtTotalNumProducts";
            this.txtTotalNumProducts.Size = new System.Drawing.Size(69, 20);
            this.txtTotalNumProducts.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Minimum Duration (Days):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Total Number of Products:";
            // 
            // txtMinDuration
            // 
            this.txtMinDuration.Enabled = false;
            this.txtMinDuration.Location = new System.Drawing.Point(161, 106);
            this.txtMinDuration.Name = "txtMinDuration";
            this.txtMinDuration.Size = new System.Drawing.Size(69, 20);
            this.txtMinDuration.TabIndex = 36;
            // 
            // txtEngagedProducts
            // 
            this.txtEngagedProducts.Enabled = false;
            this.txtEngagedProducts.Location = new System.Drawing.Point(161, 184);
            this.txtEngagedProducts.Name = "txtEngagedProducts";
            this.txtEngagedProducts.Size = new System.Drawing.Size(69, 20);
            this.txtEngagedProducts.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Maximum Duration (Days):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Products in Current Use:";
            // 
            // txtMaxDuration
            // 
            this.txtMaxDuration.Enabled = false;
            this.txtMaxDuration.Location = new System.Drawing.Point(394, 106);
            this.txtMaxDuration.Name = "txtMaxDuration";
            this.txtMaxDuration.Size = new System.Drawing.Size(69, 20);
            this.txtMaxDuration.TabIndex = 38;
            // 
            // txtTotalNumSuppliers
            // 
            this.txtTotalNumSuppliers.Enabled = false;
            this.txtTotalNumSuppliers.Location = new System.Drawing.Point(394, 158);
            this.txtTotalNumSuppliers.Name = "txtTotalNumSuppliers";
            this.txtTotalNumSuppliers.Size = new System.Drawing.Size(69, 20);
            this.txtTotalNumSuppliers.TabIndex = 46;
            // 
            // lblCostMin
            // 
            this.lblCostMin.AutoSize = true;
            this.lblCostMin.Location = new System.Drawing.Point(19, 135);
            this.lblCostMin.Name = "lblCostMin";
            this.lblCostMin.Size = new System.Drawing.Size(98, 13);
            this.lblCostMin.TabIndex = 39;
            this.lblCostMin.Text = "Lowest Base Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Total Number of Suppliers:";
            // 
            // txtMinBasePrice
            // 
            this.txtMinBasePrice.Enabled = false;
            this.txtMinBasePrice.Location = new System.Drawing.Point(161, 132);
            this.txtMinBasePrice.Name = "txtMinBasePrice";
            this.txtMinBasePrice.Size = new System.Drawing.Size(69, 20);
            this.txtMinBasePrice.TabIndex = 40;
            // 
            // txtEngagedSuppliers
            // 
            this.txtEngagedSuppliers.Enabled = false;
            this.txtEngagedSuppliers.Location = new System.Drawing.Point(161, 158);
            this.txtEngagedSuppliers.Name = "txtEngagedSuppliers";
            this.txtEngagedSuppliers.Size = new System.Drawing.Size(69, 20);
            this.txtEngagedSuppliers.TabIndex = 44;
            // 
            // lblCostMax
            // 
            this.lblCostMax.AutoSize = true;
            this.lblCostMax.Location = new System.Drawing.Point(252, 135);
            this.lblCostMax.Name = "lblCostMax";
            this.lblCostMax.Size = new System.Drawing.Size(97, 13);
            this.lblCostMax.TabIndex = 41;
            this.lblCostMax.Text = "Highest Base Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Engaged Suppliers:";
            // 
            // txtMaxBasePrice
            // 
            this.txtMaxBasePrice.Enabled = false;
            this.txtMaxBasePrice.Location = new System.Drawing.Point(394, 132);
            this.txtMaxBasePrice.Name = "txtMaxBasePrice";
            this.txtMaxBasePrice.Size = new System.Drawing.Size(69, 20);
            this.txtMaxBasePrice.TabIndex = 42;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPackageCount);
            this.Controls.Add(this.txtTotalNumProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMinDuration);
            this.Controls.Add(this.txtEngagedProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaxDuration);
            this.Controls.Add(this.txtTotalNumSuppliers);
            this.Controls.Add(this.lblCostMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinBasePrice);
            this.Controls.Add(this.txtEngagedSuppliers);
            this.Controls.Add(this.lblCostMax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaxBasePrice);
            this.Controls.Add(this.btnPackages);
            this.Name = "MainForm";
            this.Text = "TravelExperts Travel Packages Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPackageCount;
        private System.Windows.Forms.TextBox txtTotalNumProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinDuration;
        private System.Windows.Forms.TextBox txtEngagedProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaxDuration;
        private System.Windows.Forms.TextBox txtTotalNumSuppliers;
        private System.Windows.Forms.Label lblCostMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinBasePrice;
        private System.Windows.Forms.TextBox txtEngagedSuppliers;
        private System.Windows.Forms.Label lblCostMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxBasePrice;
    }
}

