using System;
using System.Linq;

namespace Sorting
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] unsortedNumbers = new int[] { 8, 16, 5, 3, 2, 8, 9, 4 };
			int[] expected = new [] { 2, 3, 4, 5, 8, 8, 9, 16 };

			var sorter = new Sorter ();
			var arrayPrinter = new ArrayPrinter ();
			int[] actual = sorter.BucketSort (unsortedNumbers);

			bool passed = actual.SequenceEqual(expected);

			if (passed) 
			{
				Console.WriteLine ("Pass");
			} 
			else 
			{
				Console.WriteLine ("Fail");
				arrayPrinter.Print(actual);
			}
		}
	}
}
