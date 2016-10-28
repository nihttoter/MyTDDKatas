namespace Katas.StringSum
{
	public class StringSum
	{
		public string Sum(string num1, string num2)
		{
			return (ParsInt(num1) + ParsInt(num2)).ToString();
		}

		private int ParsInt(string value)
		{
			int outPut;
			int.TryParse(value, out outPut);

			return outPut < 0 ? 0 : outPut;
		}
	}
}
