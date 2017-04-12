using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class MatrixRotatorTest
	{
		[Test]
		public void RotateTests_NullInput_ReturnsNull()
		{
			Assert.That(MatrixRotator.Rotate(null), Is.Null);
		}

		/*
		 * Input
		 * 1,1
		 * 1,1
		 * 
		 * Expected Output
		 * 1,1
		 * 1,1
		 */
		[Test]
		public void RotateTests_2x2SymmetricalMatrix ()
		{
			int [] [] input = { 
				new [] { 1, 1 }, 
				new [] { 1, 1 } };
			
			Assert.That (MatrixRotator.Rotate (input), Is.EqualTo (input));
		}

		/*
		 * Input
		 * 1,2
		 * 3,4
		 * 
		 * Expected Output
		 * 3,1
		 * 4,2
		 */
		[Test]
		public void Rotate_2x2AsymmetrialMatrix ()
		{
			int [] [] input = { 
				new [] { 1, 2 }, 
				new [] { 3, 4 } };
			
			int [] [] expectedOutput = { 
				new [] { 3, 1 }, 
				new [] { 4, 2 } };
			
			Assert.That (MatrixRotator.Rotate (input), Is.EqualTo (expectedOutput));
		}

		/*
		 * Input
		 * 1,2,3
		 * 4,5,6
		 * 7,8,9
		 * 
		 * Output
		 * 7,4,1
		 * 8,5,2
		 * 9,6,3
		 */
		[Test]
		public void Rotate_3x3AsymmetricalMatrix ()
		{
			int [] [] input = {
				new [] { 1, 2, 3 },
				new [] { 4, 5, 6 },
				new [] { 7, 8, 9 } };

			int [] [] expectedOutput = { 
				new [] { 7, 4, 1 }, 
				new [] { 8, 5, 2 }, 
				new [] { 9, 6, 3 } };

			var actualOutput = MatrixRotator.Rotate (input);
			Assert.That (actualOutput, Is.EqualTo (expectedOutput));
		}


		/*
		 * Input
		 * 1,2,3,4
		 * 5,6,7,8
		 * 9,10,11,12
		 * 13,14,15,16
		 * 
		 * Output
		 * 13,9,5,1
		 * 14,10,6,2
		 * 15,11,7,3
		 * 16,12,8,4
		 */
		[Test]
		public void Rotate_4x4AsymmetricalMatrix ()
		{
			int [] [] input = { 
				new [] { 1, 2, 3, 4 }, 
				new [] { 5, 6, 7, 8 }, 
				new [] { 9, 10, 11, 12 }, 
				new [] { 13, 14, 15, 16 } };
			
			int [] [] expectedOutput = { 
				new [] { 13, 9, 5, 1 }, 
				new [] { 14, 10, 6, 2 }, 
				new [] { 15, 11, 7, 3 }, 
				new [] { 16, 12, 8, 4 } };

			var actualOutput = MatrixRotator.Rotate (input);
			Assert.That (actualOutput, Is.EqualTo (expectedOutput));
		}
	}
}
