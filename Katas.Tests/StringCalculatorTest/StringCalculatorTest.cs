using System;
using NUnit.Framework;

namespace Katas.Tests.StringCalculatorTest
{
	[TestFixture]
	public class StringCalculatorTest
	{
		private StringCalculator.StringCalculator _calc;

		public StringCalculatorTest()
		{
			_calc = new StringCalculator.StringCalculator();
		}

		[Test]
		public void ZeroParam()
		{
			Assert.AreEqual(_calc.Add(""), 0);
		}

		[Test]
		public void OneParam()
		{
			Assert.AreEqual(_calc.Add("1"), 1);
		}

		[Test]
		public void TwoParams()
		{
			Assert.AreEqual(_calc.Add("1, 2"), 3);
		}

		[Test]
		public void MultipleParams()
		{
			Assert.AreEqual(_calc.Add("1, 2, 3, 4, 5"), 15);
		}

		[Test]
		public void NewLineDelimitedParams()
		{
			Assert.AreEqual(_calc.Add("1, 2 \n 3, 4, 5"), 15);
		}

		[Test]
		public void NotCorrectParams()
		{
			Assert.Throws<FormatException>(() => _calc.Add("1, a, 4, 5"));
		}

		[Test]
		public void EmptyParams()
		{
			Assert.Throws<FormatException>(() => _calc.Add("1, , 4, 5"));
		}

		[Test]
		public void CustomerDelimiter()
		{
			Assert.AreEqual(_calc.Add("//;\n1;2"), 3);
		}
	}
}
