using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace prog8form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string str = textBox1.Text;
				var result = new Regex(@"\d+").Matches(str).Cast<Match>().Max(x => int.Parse(x.ToString()));
				string res = $"Ваша строка: {str}";
				res += "" + Environment.NewLine;
				res += $"Максимальное число в строке: {result}";
				MessageBox.Show($"{res}", "Результат");
			}
			catch
			{
				MessageBox.Show("Строка должна состоять из целых чисел", "Ошибка");
				return;
			}
		}
	}
}
