using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace prog8
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				try
				{
					Console.WriteLine("Введите строку: ");
					string str = Console.ReadLine();
					var result = new Regex(@"\d+").Matches(str).Cast<Match>().Max(x => int.Parse(x.ToString()));
					Console.WriteLine($"Максимальное число в строке: {result}");
					Console.ReadKey(true);
					break;
				}
				catch
				{
					Console.WriteLine("Строка должна состоять из целых чисел");
				}
			} while (true);
			
		}
	}
}
