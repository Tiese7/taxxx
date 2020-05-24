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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int a = int.Parse(textBox1.Text);
			int b = int.Parse(textBox2.Text);
			int c = int.Parse(textBox3.Text);
			int x, outcome;
			x = a * 12;
			outcome = x + c + b;
			textBox4.Text = outcome.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form3 mainform = new Form3();
			mainform.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int pers = int.Parse(numericUpDown1.Text);
			int erreg = int.Parse(numericUpDown7.Text);
			int child61 = int.Parse(numericUpDown3.Text);
			int child612 = int.Parse(numericUpDown4.Text);
			int child613 = int.Parse(numericUpDown5.Text);
			int pregnant = int.Parse(numericUpDown6.Text);
			int income = int.Parse(textBox4.Text);
			int medad=0, memom=0, yourdad=0, yourmom=0;
			int couplepoor=0, w, x, y, z, xyz;
			if (radioButton3.Checked)
			{
				couplepoor = 60000;
			}
			if (radioButton7.Checked)
			{
				medad = 30000;
			}
			if (radioButton9.Checked)
			{
				memom = 30000;
			}
			if (radioButton11.Checked)
			{
				yourdad = 30000;
			}
			if (radioButton13.Checked)
			{
				yourmom = 30000;
			}
			pers =  60000;
			w = erreg * 60000;
			x = child61 * 30000;
			y = child612 * 30000;
			z = child613 * 60000;
			int  total;
			total = couplepoor + medad + memom + yourmom + yourdad + w + x + y + z + pers + pregnant;
			textBox6.Text = total.ToString();
			xyz = income - total;
			textBox5.Text = xyz.ToString();
			int f;
			if (xyz > 5000001)
			{
				f = (xyz * 35 / 100);
			}
			else if (xyz > 2000001)
			{
				f = (xyz * 30 / 100);
			}
			else if (xyz > 1000001)
			{
				f = (xyz * 25 / 100);
			}
			else if (xyz > 750001)
			{
				f = (xyz * 20 / 100);
			}
			else if (xyz > 500001)
			{
				f = (xyz * 15 / 100);
			}
			else if (xyz > 300001)
			{
				f = (xyz * 10 / 100);
			}
			else if (xyz > 150001)
			{
				f = (xyz * 5 / 100);
			}
			else
			{
				f = (0);
			}
			textBox7.Text = f.ToString();
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton4.Checked)
			{
				numericUpDown3.Enabled = true;
				numericUpDown4.Enabled = true;
				numericUpDown5.Enabled = true;
			}
			else
			{
				numericUpDown3.Enabled = false;
				numericUpDown4.Enabled = false;
				numericUpDown5.Enabled = false;
			}
		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton5.Checked)
			{
				int c1, c2, c3;
				numericUpDown3.Enabled = false;
				numericUpDown4.Enabled = false;
				numericUpDown5.Enabled = false;
				c1 = int.Parse(numericUpDown3.Text);
				c2 = int.Parse(numericUpDown4.Text);
				c3 = int.Parse(numericUpDown5.Text);
				c1 = 0;
				c2 = 0;
				c3 = 0;
			}
		}
	}
}
