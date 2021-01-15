namespace _15
{
    partial class Form1
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
            this.labelNama = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.listBoxHarga = new System.Windows.Forms.ListBox();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.labelIndicator = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelIndicator2 = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonJumbo = new System.Windows.Forms.RadioButton();
            this.labelIndicator3 = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(13, 13);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(266, 36);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "RESTO BU DEWI";
            this.labelNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(16, 64);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(41, 17);
            this.labelItem.TabIndex = 1;
            this.labelItem.Text = "Items";
            this.labelItem.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.ItemHeight = 16;
            this.listBoxItem.Location = new System.Drawing.Point(19, 94);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(251, 260);
            this.listBoxItem.TabIndex = 2;
            this.listBoxItem.SelectedIndexChanged += new System.EventHandler(this.listBoxItem_SelectedIndexChanged);
            // 
            // listBoxHarga
            // 
            this.listBoxHarga.FormattingEnabled = true;
            this.listBoxHarga.ItemHeight = 16;
            this.listBoxHarga.Location = new System.Drawing.Point(277, 94);
            this.listBoxHarga.Name = "listBoxHarga";
            this.listBoxHarga.Size = new System.Drawing.Size(142, 260);
            this.listBoxHarga.TabIndex = 3;
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(6, 13);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(87, 21);
            this.radioButtonMakanan.TabIndex = 4;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            this.radioButtonMakanan.CheckedChanged += new System.EventHandler(this.radioButtonMakanan_CheckedChanged);
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(123, 13);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(86, 21);
            this.radioButtonMinuman.TabIndex = 5;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            this.radioButtonMinuman.CheckedChanged += new System.EventHandler(this.radioButtonMinuman_CheckedChanged);
            // 
            // labelIndicator
            // 
            this.labelIndicator.AutoSize = true;
            this.labelIndicator.Location = new System.Drawing.Point(464, 137);
            this.labelIndicator.Name = "labelIndicator";
            this.labelIndicator.Size = new System.Drawing.Size(43, 17);
            this.labelIndicator.TabIndex = 6;
            this.labelIndicator.Text = "Menu";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(513, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelIndicator2
            // 
            this.labelIndicator2.AutoSize = true;
            this.labelIndicator2.Location = new System.Drawing.Point(695, 137);
            this.labelIndicator2.Name = "labelIndicator2";
            this.labelIndicator2.Size = new System.Drawing.Size(51, 17);
            this.labelIndicator2.TabIndex = 8;
            this.labelIndicator2.Text = "Harga:";
            this.labelIndicator2.Click += new System.EventHandler(this.labelIndicator2_Click);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(760, 137);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(17, 17);
            this.labelHarga.TabIndex = 9;
            this.labelHarga.Text = "0";
            this.labelHarga.Click += new System.EventHandler(this.labelHarga_Click);
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Checked = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(9, 14);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(74, 21);
            this.radioButtonNormal.TabIndex = 10;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // radioButtonJumbo
            // 
            this.radioButtonJumbo.AutoSize = true;
            this.radioButtonJumbo.Location = new System.Drawing.Point(126, 14);
            this.radioButtonJumbo.Name = "radioButtonJumbo";
            this.radioButtonJumbo.Size = new System.Drawing.Size(71, 21);
            this.radioButtonJumbo.TabIndex = 11;
            this.radioButtonJumbo.Text = "Jumbo";
            this.radioButtonJumbo.UseVisualStyleBackColor = true;
            this.radioButtonJumbo.CheckedChanged += new System.EventHandler(this.radioButtonJumbo_CheckedChanged);
            // 
            // labelIndicator3
            // 
            this.labelIndicator3.AutoSize = true;
            this.labelIndicator3.Location = new System.Drawing.Point(461, 206);
            this.labelIndicator3.Name = "labelIndicator3";
            this.labelIndicator3.Size = new System.Drawing.Size(35, 17);
            this.labelIndicator3.TabIndex = 12;
            this.labelIndicator3.Text = "Size";
            this.labelIndicator3.Click += new System.EventHandler(this.labelIndicator3_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(464, 298);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(179, 56);
            this.buttonBuy.TabIndex = 13;
            this.buttonBuy.Text = "BUY";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            this.buttonBuy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BuyClick);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(668, 298);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(155, 56);
            this.buttonCheckOut.TabIndex = 14;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMakanan);
            this.groupBox1.Controls.Add(this.radioButtonMinuman);
            this.groupBox1.Location = new System.Drawing.Point(467, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 40);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonJumbo);
            this.groupBox2.Controls.Add(this.radioButtonNormal);
            this.groupBox2.Location = new System.Drawing.Point(464, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 41);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(277, 372);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(142, 28);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelIndicator3);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelIndicator2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelIndicator);
            this.Controls.Add(this.listBoxHarga);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.ListBox listBoxHarga;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.Label labelIndicator;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelIndicator2;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonJumbo;
        private System.Windows.Forms.Label labelIndicator3;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDelete;
    }
}

