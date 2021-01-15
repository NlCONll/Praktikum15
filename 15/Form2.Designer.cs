namespace _15
{
    partial class Form2
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
            this.labelnameSubtotal = new System.Windows.Forms.Label();
            this.labelnametax = new System.Windows.Forms.Label();
            this.labelnametotal = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.buttonCal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelnameSubtotal
            // 
            this.labelnameSubtotal.AutoSize = true;
            this.labelnameSubtotal.Location = new System.Drawing.Point(36, 13);
            this.labelnameSubtotal.Name = "labelnameSubtotal";
            this.labelnameSubtotal.Size = new System.Drawing.Size(60, 17);
            this.labelnameSubtotal.TabIndex = 0;
            this.labelnameSubtotal.Text = "Subtotal";
            // 
            // labelnametax
            // 
            this.labelnametax.AutoSize = true;
            this.labelnametax.Location = new System.Drawing.Point(36, 46);
            this.labelnametax.Name = "labelnametax";
            this.labelnametax.Size = new System.Drawing.Size(31, 17);
            this.labelnametax.TabIndex = 1;
            this.labelnametax.Text = "Tax";
            // 
            // labelnametotal
            // 
            this.labelnametotal.AutoSize = true;
            this.labelnametotal.Location = new System.Drawing.Point(36, 113);
            this.labelnametotal.Name = "labelnametotal";
            this.labelnametotal.Size = new System.Drawing.Size(40, 17);
            this.labelnametotal.TabIndex = 3;
            this.labelnametotal.Text = "Total";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(211, 13);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(16, 17);
            this.labelSubtotal.TabIndex = 4;
            this.labelSubtotal.Text = "0";
            this.labelSubtotal.Click += new System.EventHandler(this.labelSubtotal_Click);
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(211, 46);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(16, 17);
            this.labelTax.TabIndex = 5;
            this.labelTax.Text = "0";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(211, 81);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(16, 17);
            this.labelDiscount.TabIndex = 6;
            this.labelDiscount.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(211, 113);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(16, 17);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "0";
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Location = new System.Drawing.Point(12, 80);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(89, 21);
            this.checkBoxDiscount.TabIndex = 8;
            this.checkBoxDiscount.Text = " Discount";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            this.checkBoxDiscount.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonCal
            // 
            this.buttonCal.Location = new System.Drawing.Point(39, 151);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(188, 30);
            this.buttonCal.TabIndex = 9;
            this.buttonCal.Text = "CALCULATE";
            this.buttonCal.UseVisualStyleBackColor = true;
            this.buttonCal.Click += new System.EventHandler(this.buttonCal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 22);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "%";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCal);
            this.Controls.Add(this.checkBoxDiscount);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.labelnametotal);
            this.Controls.Add(this.labelnametax);
            this.Controls.Add(this.labelnameSubtotal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnameSubtotal;
        private System.Windows.Forms.Label labelnametax;
        private System.Windows.Forms.Label labelnametotal;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}