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
			int o, pov,jav = 0, xy, fx;
			o = (tpri * 10) / 100;
			pov = a1 + b1 + c1 + d1 + eg + f + g;
			if (pov > o)
			{
				jav = o;
				textBox5.Text = jav.ToString();
			}
			else
			{
				jav = pov;
				textBox5.Text = jav.ToString();
			}
			xy = tpri - jav;
			textBox6.Text = xy.ToString();

			if (xy > 5000001)
			{
				fx = (xy * 35 / 100);
			}
			else if (xy > 2000001)
			{
				fx = (xy * 30 / 100);
			}
			else if (xy > 1000001)
			{
				fx = (xy * 25 / 100);
			}
			else if (xy > 750001)
			{
				fx = (xy * 20 / 100);
			}
			else if (xy > 500001)
			{
				fx = (xy * 15 / 100);
			}
			else if (xy > 300001)
			{
				fx = (xy * 10 / 100);
			}
			else if (xy > 150001)
			{
				fx = (xy * 5 / 100);
			}
			else
			{
				fx = (0);
			}
			textBox7.Text = fx.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form3 mainform = new Form3();
			mainform.Show();
		}
	}
}
