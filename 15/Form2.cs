using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelSubtotal_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            labelSubtotal.Text = Convert.ToString(Form1.subtotal);

            double tax = Form1.subtotal / 10;
            labelTax.Text = Convert.ToString(tax);

            double discount = 0;
            if (checkBoxDiscount.Checked == true)
            {
                int berapaPersen = Convert.ToInt32(textBox1.Text);
                discount = Form1.subtotal / berapaPersen;
                labelDiscount.Text = Convert.ToString(discount);
            }

            double total = Convert.ToDouble(Form1.subtotal) + Convert.ToDouble(tax) - discount;
            labelTotal.Text = Convert.ToString(total);
        }
    }
}
