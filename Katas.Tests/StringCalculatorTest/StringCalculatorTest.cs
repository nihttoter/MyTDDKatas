using System;
using NUnit.Framework;

namespace Katas.Tests.StringCalculatorTest
{
	[TestFixture]
	public class StringCalculatorTest
	{
		private readonly StringCalculator.StringCalculator m_calc;

		public StringCalculatorTest()
		{
			m_calc = new StringCalculator.StringCalculator();
		}

		[Test]
		public void CustomerDelimiter()
		{
			Assert.AreEqual(m_calc.Add("//;\n1;2"), 3);
		}

		[Test]
		public void EmptyParams()
		{
			Assert.Throws<FormatException>(() => m_calc.Add("1, , 4, 5"));
		}

		[Test]
		public void MultipleParams()
		{
			Assert.AreEqual(m_calc.Add("1, 2, 3, 4, 5"), 15);
		}

		[Test]
		public void NewLineDelimitedParams()
		{
			Assert.AreEqual(m_calc.Add("1, 2 \n 3, 4, 5"), 15);
		}

		[Test]
		public void NotCorrectParams()
		{
			Assert.Throws<FormatException>(() => m_calc.Add("1, a, 4, 5"));
		}

		[Test]
		public void OneParam()
		{
			Assert.AreEqual(m_calc.Add("1"), 1);
		}

		[Test]
		public void TwoParams()
		{
			Assert.AreEqual(m_calc.Add("1, 2"), 3);
		}

		[Test]
		public void ZeroParam()
		{
			Assert.AreEqual(m_calc.Add(string.Empty), 0);
		}
	}
}
