using NUnit.Framework;

namespace Katas.Tests.StringSumTest
{
	[TestFixture]
	public class StringSumTest
	{
		private readonly StringSum.StringSum _calc;

		public StringSumTest()
		{
			_calc = new StringSum.StringSum();
		}

		[Test]
		public void IsWorks()
		{
			Assert.AreEqual(_calc.Sum("1", "1"), "2");
		}

		[Test]
		public void IsNotNatural()
		{
			Assert.AreEqual(_calc.Sum("-1", "1"), "1");
		}

		[Test]
		public void IsNotNumber()
		{
			Assert.AreEqual(_calc.Sum("a", "1"), "1");
		}
	}
}
