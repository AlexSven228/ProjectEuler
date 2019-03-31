using System;

namespace ProjectEuler.Problems
{
	class Problem1 : BaseProblem
	{
		private int maxNumber = 1000;

		public override void Go()
		{
			long result = 0;
			for (int i = 0; i < maxNumber; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					result += i;
				}
			}
			Console.WriteLine($"Результат: {result}");
		}
	}
}