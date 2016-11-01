using NUnit.Framework;

namespace Katas.Tests.StringSumTest
{
	[TestFixture]
	public class StringSumTest
	{
		private readonly StringSum.StringSum m_calc;

		public StringSumTest()
		{
			m_calc = new StringSum.StringSum();
		}

		[Test]
		public void IsNotNatural()
		{
			Assert.AreEqual(m_calc.Sum("-1", "1"), "1");
		}

		[Test]
		public void IsNotNumber()
		{
			Assert.AreEqual(m_calc.Sum("a", "1"), "1");
		}

		[Test]
		public void IsWorks()
		{
			Assert.AreEqual(m_calc.Sum("1", "1"), "2");
		}
	}
}
