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
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int a, b, c, d, eg, f, g, a1, b1, c1, d1, tpri;
			a = int.Parse(numericUpDown1.Text);
			b = int.Parse(numericUpDown2.Text);
			c = int.Parse(numericUpDown3.Text);
			d = int.Parse(numericUpDown4.Text);
			eg = int.Parse(numericUpDown5.Text);
			f = int.Parse(numericUpDown6.Text);
			g = int.Parse(numericUpDown7.Text);
			tpri = int.Parse(textBox4.Text);

			a1 = a * 2;
			textBox8.Text = a1.ToString();
			b1 = b * 2;
			textBox9.Text = b1.ToString();
			c1 = c * 2;
			textBox10.Text = c1.ToString();
			d1 = d * 2;
			textBox11.Text = d1.ToString();
			
			textBox12.Text = eg.ToString();
			textBox13.Text = f.ToString();
			textBox14.Text = g.ToString();
			int o, pov,jac = 0, xy;
			o = (tpri * 10) / 100;
			pov = a1 + b1 + c1 + d1 + eg + f + g;
			if (pov > o)
			{
				jac = o;
				textBox5.Text = jac.ToString();
			}
			else
			{
				jac = pov;
				textBox5.Text = jac.ToString();
			}
			xy = tpri - jac;
			textBox6.Text = xy.ToString();

			
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form5 mainform = new Form5();
			mainform.Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Form7 prix = new Form7();
			prix.textBox4.Text = textBox6.Text;
			prix.Show();
			this.Hide();
		}
	}
}
