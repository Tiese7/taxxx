using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace เย็ดแม่1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k1, k2, k3, k4, k5, k6, k7;
            if (checkBox1.Checked)
            {
                k1 = int.Parse(numericUpDown1.Text);
                if (k1 <= 9000)
                {
                    textBox12.Text = k1.ToString();
                }
                else
                {
                    textBox12.Text = "9000";
                }
                h1.Text = textBox12.Text;
            }
            else
            {
                k1 = 0;
            }

            if (checkBox2.Checked)
            {
                k2 = int.Parse(numericUpDown2.Text);
                if (k2 <= 100000)
                {
                    textBox12.Text = k2.ToString();
                }
                else
                {
                    textBox12.Text = "100000";
                }
                h2.Text = textBox12.Text;
            }
            else
            {
                k2 = 0;
            }

            if (checkBox3.Checked)
            {
                k2 = int.Parse(numericUpDown2.Text);
                k3 = int.Parse(numericUpDown3.Text);
                if (k2 <= 100000)
                {
                    textBox12.Text = k3.ToString();
                }
                else
                {
                    textBox12.Text = "0";
                }
                h3.Text = textBox12.Text;
            }
            else
            {
                k3 = 0;
            }

            if (checkBox4.Checked)
            {
                k4 = int.Parse(numericUpDown4.Text);
                if (k4 <= 15000)
                {
                    textBox12.Text = k4.ToString();
                }
                else
                {
                    textBox12.Text = "15000";
                }
                h4.Text = textBox12.Text;
            }
            else
            {
                k4 = 0;
            }
            if(checkBox5.Checked)
            {
                k5 = int.Parse(numericUpDown5.Text);
                if(radioButton3.Checked)
                {
                    if(k5<=10000)
                    {
                        textBox12.Text = k5.ToString();
                    }
                    else
                    {
                        textBox12.Text = "10000";
                    }
                }
            else
                {
                    k5 = 0;
                    textBox12.Text = "0";
                }
                h5.Text = textBox12.Text;
            }
            if (checkBox6.Checked)
            {
                k6 = int.Parse(numericUpDown6.Text);
                if (k6 <= 10000)
                {
                    textBox12.Text = k6.ToString();
                }
                else
                {
                    textBox12.Text = "10000";
                }
                h6.Text = textBox12.Text;
            }
            else
            {
                k6 = 0;
            }
            if (checkBox7.Checked)
            {
                k7 = int.Parse(numericUpDown7.Text);
                if (k7 <= 100000)
                {
                    textBox12.Text = k7.ToString();
                }
                else
                {
                    textBox12.Text = "100000";
                }
                h7.Text = textBox12.Text;
            }
            else
            {
                k7 = 0;
            }

            int o1 = int.Parse(h1.Text);
            int o2 = int.Parse(h2.Text);
            int o3 = int.Parse(h3.Text);
            int o4 = int.Parse(h4.Text);
            int o5 = int.Parse(h5.Text);
            int o6 = int.Parse(h6.Text);
            int o7 = int.Parse(h7.Text);
            int tax;
            tax = o1 + o2 + o3 + o4 + o5 + o6 + o7;
            textBox12.Text = tax.ToString();
            int meow;
            int yen = int.Parse(textBox4.Text);
            int ted = int.Parse(textBox12.Text);
            meow = yen - ted;
            textBox5.Text = meow.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void hee2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void h1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 mainform = new Form4();
            mainform.Show();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 prix = new Form5();
            prix.textBox4.Text = textBox5.Text;
            prix.Show();
            this.Hide();
        }
    }
}
