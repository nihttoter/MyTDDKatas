﻿using System;
using System.Linq;

namespace Katas.StringCalculator
{
	public class StringCalculator
	{
		private readonly string[] defaultSeparaters;

		public StringCalculator()
		{
			defaultSeparaters = new string[]
			{
				Environment.NewLine,
				",",
				"\n"
			};
		}

		public int Add(string numbers)
		{
			if (!numbers.Split('\n')[0].StartsWith(@"//")) {
				return Calculate(numbers, defaultSeparaters);
			}
			else
			{
				var customerSeparaters = numbers.Split('\n')[0].Replace(@"//", string.Empty);
			}

			return Calculate(numbers, defaultSeparaters);
		}







		private int ParsInt(string number)
		{
			return int.Parse(number);
		}

		private int Calculate(string numbers, string[] separaters) {
			if (string.IsNullOrWhiteSpace(numbers))
				return 0;

			return numbers.Split(separaters, StringSplitOptions.None).Sum(ParsInt);
		}
	}
}
