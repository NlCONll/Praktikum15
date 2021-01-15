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
    public partial class Form1 : Form
    {
        public static string[] menuMinum = new string[4] { "Es Teh", "Teh Hangat", "Nutrisari", "Aqua"};
        public static string[] menuMakan = new string[4] { "Nasi Goreng", "Nasi Goreng Spesial", "Nasi Goreng Petai", "Ayam bakar" };
        public static int[] hargaMakan = new int[4] { 10000, 12000, 15000, 15000 };
        public static int[] hargaMinum = new int[4] { 5000, 3000, 6000, 2000 };
        public static int[] hargaMinumJumbo = new int[4] { 7000, 5000, 10000, 5000 };
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelIndicator2_Click(object sender, EventArgs e)
        {

        }

        private void labelIndicator3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public static int subtotal;
        public static int berapa;
        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
           

            if (listBoxItem.Items.Count == 0)
            {
                MessageBox.Show("Pilih Menu!");
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            berapa = listBoxHarga.Items.Count;
            for (int i = 0; i < berapa; i++)
            {
                subtotal = subtotal + Convert.ToInt32(listBoxHarga.Items[i]);
            }

        }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Nasi Goreng")
            {
                labelHarga.Text = Convert.ToString(10000);
            }
            if (comboBox1.Text == "Nasi Goreng Spesial")
            {
                labelHarga.Text = Convert.ToString(12000);
            }
            if (comboBox1.Text == "Nasi Goreng Petai")
            {
                labelHarga.Text = Convert.ToString(15000);
            }
            if (comboBox1.Text == "Ayam Bakar")
            {
                labelHarga.Text = Convert.ToString(15000);
            }

            if (comboBox1.Text == "Es Teh")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(7000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(5000);
                }
            }
            if (comboBox1.Text == "Teh Hangat")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(5000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(3000);
                }
            }
            if (comboBox1.Text == "Nutrisari")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(10000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(6000);
                }

            }
            if (comboBox1.Text == "Aqua")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(5000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(2000);
                }
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            listBoxItem.Items.Add(comboBox1.Text);
            if (comboBox1.Text == "Nasi Goreng")
            {
                listBoxHarga.Items.Add(10000);
            }
            if (comboBox1.Text == "Nasi Goreng Spesial")
            {
                listBoxHarga.Items.Add(12000);
            }
            if (comboBox1.Text == "Nasi Goreng Petai")
            {
                listBoxHarga.Items.Add(15000);
            }
            if (comboBox1.Text == "Ayam Bakar")
            {
                listBoxHarga.Items.Add(15000);
            }


            if (comboBox1.Text == "Es Teh")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    listBoxHarga.Items.Add(7000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    listBoxHarga.Items.Add(5000);
                }
            }
            if (comboBox1.Text == "Teh Hangat")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    listBoxHarga.Items.Add(5000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    listBoxHarga.Items.Add(3000);
                }
            }
            if (comboBox1.Text == "Nutrisari")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    listBoxHarga.Items.Add(10000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    listBoxHarga.Items.Add(6000);
                }
                
            }
            if (comboBox1.Text == "Aqua")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    listBoxHarga.Items.Add(5000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    listBoxHarga.Items.Add(2000);
                }
            }
        }
        private void BuyClick(object sender, MouseEventArgs e)
        {
            
        }

        private void radioButtonMakanan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMakanan.Checked == true)
            {
                comboBox1.Items.Add(menuMakan[0]);
                comboBox1.Items.Add(menuMakan[1]);
                comboBox1.Items.Add(menuMakan[2]);
                comboBox1.Items.Add(menuMakan[3]);

                radioButtonNormal.Enabled = false;
                radioButtonJumbo.Enabled = false;
            }
            if (radioButtonMakanan.Checked == false)
            {
                comboBox1.Items.Clear();
            }
            
        }

        private void radioButtonMinuman_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuman.Checked == true)
            {
                comboBox1.Items.Add(menuMinum[0]);
                comboBox1.Items.Add(menuMinum[1]);
                comboBox1.Items.Add(menuMinum[2]);
                comboBox1.Items.Add(menuMinum[3]);

                radioButtonNormal.Enabled = true;
                radioButtonJumbo.Enabled = true;
            }
            else
            {
                comboBox1.Items.Clear();
            }

            if(radioButtonMinuman.Checked == false)
            {
                radioButtonNormal.Enabled = false;
                radioButtonJumbo.Enabled = false;
            }
            
        }

        private void labelHarga_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Es Teh")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(7000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(5000);
                }
            }
            if (comboBox1.Text == "Teh Hangat")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(5000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(3000);
                }
            }
            if (comboBox1.Text == "Nutrisari")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(10000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(6000);
                }

            }
            if (comboBox1.Text == "Aqua")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(5000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(2000);
                }
            }
        }

        private void radioButtonJumbo_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Es Teh")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(7000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(5000);
                }
            }
            if (comboBox1.Text == "Teh Hangat")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(5000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(3000);
                }
            }
            if (comboBox1.Text == "Nutrisari")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(10000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(6000);
                }

            }
            if (comboBox1.Text == "Aqua")
            {
                if (radioButtonJumbo.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(5000);
                }
                if (radioButtonNormal.Checked == true)
                {
                    labelHarga.Text = Convert.ToString(2000);
                }
            }
        }

        private void listBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxHarga.Items.Count == 0)
            {
                buttonDelete.Enabled = false;
            }
            if (listBoxItem.Items.Count == 0)
            {
                buttonDelete.Enabled = false;
            }
            if (listBoxItem.Items.Count != 0)
            {
                buttonDelete.Enabled = true;

                listBoxHarga.Items.Remove(listBoxHarga.SelectedItem);
                listBoxItem.Items.Remove(listBoxItem.SelectedItem);
            }
            if (listBoxHarga.Items.Count != 0)
            {
                buttonDelete.Enabled = true;
                listBoxHarga.Items.Remove(listBoxHarga.SelectedItem);
                listBoxItem.Items.Remove(listBoxItem.SelectedItem);
            }
        }
    }
}
