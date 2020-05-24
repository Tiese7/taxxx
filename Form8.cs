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
	public partial class Form8 : Form
	{
		public Form8()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form3 mainform = new Form3();
			mainform.Show();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int f, x;
			x = int.Parse(textBox1.Text);

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
			textBox2.Text = f.ToString();
		}
	}
}
