﻿using System;
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
	public partial class Form5 : Form
	{
       
		public Form5()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int a = int.Parse(textBox1.Text); //เงินเดือน
			int b = int.Parse(textBox2.Text); //โบนัส
			int c = int.Parse(textBox3.Text); //รายได้อื่นๆ
			int x, outcome;
			x = a * 12; //เงินเดือนคูณ 12
			outcome = x + c + b;
			textBox4.Text = outcome.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int htax = int.Parse(numericUpDown1.Text);
			int hpri = int.Parse(numericUpDown2.Text);
			int tpri = int.Parse(textBox4.Text);
			int twenty, fourper, totale, x, f;
			twenty = (hpri * 20) / 100;
			textBox5.Text = twenty.ToString();
			fourper = (twenty * 4) / 100;
			textBox6.Text = fourper.ToString();
			totale = htax + fourper;
			textBox8.Text = totale.ToString();
			x = tpri - totale;
			textBox9.Text = x.ToString();

            if (x > 5000001)
            {
                f = (x * 35 / 100);
            }
            else if (x > 2000001)
            {
                f = (x * 30 / 100);
            }
            else if (x > 1000001)
            {
                f = (x * 25 / 100);
            }
            else if (x > 750001)
            {
                f = (x * 20 / 100);
            }
            else if (x > 500001)
            {
                f = (x * 15 / 100);
            }
            else if (x > 300001)
            {
                f = (x * 10 / 100);
            }
            else if (x > 150001)
            {
                f = (x * 5 / 100);
            }
            else
            {
                f = (0);
            }
            textBox10.Text = f.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;

            }
            else
            {
                groupBox1.Enabled = false;
                int hpri = int.Parse(numericUpDown2.Text);
                hpri = 0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = false;
                int hpri = int.Parse(numericUpDown3.Text);
                hpri = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int htax = int.Parse(numericUpDown1.Text);
            int hpri = int.Parse(numericUpDown3.Text);
            int tpri = int.Parse(textBox4.Text);
            int hj, totale, x, f;

            if (hpri < 200000)
            {
                hj = hpri;
                textBox7.Text = hj.ToString();
                totale = htax + hj;
                textBox13.Text = totale.ToString();
                x = tpri - totale;
                textBox12.Text = x.ToString();
                if (x > 5000001)
                {
                    f = (x * 35 / 100);
                }
                else if (x > 2000001)
                {
                    f = (x * 30 / 100);
                }
                else if (x > 1000001)
                {
                    f = (x * 25 / 100);
                }
                else if (x > 750001)
                {
                    f = (x * 20 / 100);
                }
                else if (x > 500001)
                {
                    f = (x * 15 / 100);
                }
                else if (x > 300001)
                {
                    f = (x * 10 / 100);
                }
                else if (x > 150001)
                {
                    f = (x * 5 / 100);
                }
                else
                {
                    f = (0);
                }
                textBox11.Text = f.ToString();
            }
            else if (hpri < 5000001)
            {
                hj = 200000;
                textBox7.Text = hj.ToString();
                totale = htax + hj;
                textBox13.Text = totale.ToString();
                x = tpri - totale;
                textBox12.Text = x.ToString();
                if (x > 5000001)
                {
                    f = (x * 35 / 100);
                }
                else if (x > 2000001)
                {
                    f = (x * 30 / 100);
                }
                else if (x > 1000001)
                {
                    f = (x * 25 / 100);
                }
                else if (x > 750001)
                {
                    f = (x * 20 / 100);
                }
                else if (x > 500001)
                {
                    f = (x * 15 / 100);
                }
                else if (x > 300001)
                {
                    f = (x * 10 / 100);
                }
                else if (x > 150001)
                {
                    f = (x * 5 / 100);
                }
                else
                {
                    f = (0);
                }
                textBox11.Text = f.ToString();

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 mainform = new Form3();
            mainform.Show();
        }
    }
}