using System;
using System.Linq;

namespace Katas.StringCalculator
{
	public class StringCalculator
	{
		private readonly string[] m_defaultSeparaters;

		public StringCalculator()
		{
			m_defaultSeparaters = new[]
			{
				Environment.NewLine,
				",",
				"\n"
			};
		}

		public int Add(string numbers)
		{
			string[] customerSeparaters;

			if (!numbers.Split('\n')[0].StartsWith(@"//"))
			{
				customerSeparaters = m_defaultSeparaters;
			}
			else
			{
				customerSeparaters = new[] { numbers.Split('\n')[0].Replace(@"//", string.Empty) };
				numbers = numbers.Split('\n')[1];
			}

			return Calculate(numbers, customerSeparaters);
		}

		private int ParsInt(string number)
		{
			return int.Parse(number);
		}

		private int Calculate(string numbers, string[] separaters)
		{
			if (string.IsNullOrWhiteSpace(numbers))
				return 0;

			return numbers.Split(separaters, StringSplitOptions.None).Sum(ParsInt);
		}
	}
}
