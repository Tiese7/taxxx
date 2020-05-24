using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace เย็ดแม่1
{
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://money.kapook.com/view209436.html");
		}

		private void label36_Click(object sender, EventArgs e)
		{

		}

		private void label35_Click(object sender, EventArgs e)
		{

		}

		private void label34_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form3 mainform = new Form3();
			mainform.Show();
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
			int a1, b1, c1, d1, e1, f1, g1, h1, i1, mainsub, tax, x, f;
			a1 = int.Parse(textBox4.Text);
			b1 = int.Parse(numericUpDown1.Text);
			c1 = int.Parse(numericUpDown2.Text);
			d1 = int.Parse(numericUpDown3.Text);
			e1 = int.Parse(numericUpDown4.Text);
			f1 = int.Parse(numericUpDown5.Text);
			g1 = int.Parse(numericUpDown6.Text);
			h1 = int.Parse(numericUpDown7.Text);
			i1 = int.Parse(numericUpDown8.Text);
			mainsub = f1 + g1;
			if (mainsub > 20000)
			{
				mainsub = 20000;
			}
			if (mainsub < 20000)
			{
				mainsub = f1 + g1;
			}
			tax = b1 + c1 + d1 + e1 + mainsub + h1 + i1;
			textBox5.Text = tax.ToString();
			x = a1 - tax;
			textBox6.Text = x.ToString();
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
			textBox7.Text = f.ToString();
		}
	}
}
