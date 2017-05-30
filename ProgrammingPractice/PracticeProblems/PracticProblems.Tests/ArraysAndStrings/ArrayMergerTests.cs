using System;
using NUnit.Framework;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class ArrayMergerTests
	{

		[Test]
		public void Test ()
		{
			int [] array = new int [5];
			array [0] = 5;
			array [1] = 100;
			array [2] = 14;
			array [3] = 10;
			array [4] = 2;

			Array.Sort (array);

			for (int i = 0; i < 5; i++) 
			{
				Console.WriteLine (array [i]);
			}
		}
	}
}
