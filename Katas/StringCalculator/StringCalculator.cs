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
			if (string.IsNullOrWhiteSpace(numbers))
				return 0;

			if (numbers.Split('\n')[0].StartsWith(@"//"))
			{
			}

			return Calculate(numbers, m_defaultSeparaters);
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
