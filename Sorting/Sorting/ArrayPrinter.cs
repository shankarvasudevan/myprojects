using System;

namespace Sorting
{
	public class ArrayPrinter
	{
		public void Print(int[] numbers)
		{
			for (int i = 0; i < numbers.Length; i++) 
			{
				Console.Write("{0} ", numbers[i]);
			}

			Console.WriteLine ();
		}
	}
}

