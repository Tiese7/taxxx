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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 group2 = new Form1();
			group2.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form4 group1 = new Form4();
			group1.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form5 group3 = new Form5();
			group3.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form6 group4 = new Form6();
			group4.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form7 group5 = new Form7();
			group5.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int a = int.Parse(textBox1.Text);
			int b = int.Parse(textBox2.Text);
			int c = int.Parse(textBox3.Text);
			int x, outcome;
			x = a * 12;
			outcome = x + c + b;
			textBox4.Text = outcome.ToString();

		}

		private void button7_Click(object sender, EventArgs e)
		{
			Form4 prix = new Form4();
			prix.textBox4.Text = textBox4.Text;
			prix.Show();
			this.Hide();
		}
	}
}
