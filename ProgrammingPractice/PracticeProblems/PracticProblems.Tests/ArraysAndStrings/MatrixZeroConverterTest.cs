using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class MatrixZeroConverterTest
	{
		[Test]
		public void SetZeroIfZero_NullMatrix_ReturnsNull()
		{
			int [] [] matrix = null;

			MatrixZeroConverter.SetZeroIfZero (matrix);
			Assert.That (matrix, Is.Null);
		}

		[Test]
		public void SetZeroIfZero_1x1MatrixNonZero_NoChange ()
		{
			int [] [] matrix = { new [] { 1 } };
			int [] [] expectedOutput = { new [] { 1 } };

			MatrixZeroConverter.SetZeroIfZero (matrix);
			Assert.That (matrix, Is.EqualTo (expectedOutput));
		}

		[Test]
		public void SetZeroIfZero_1x1MatrixZero_NoChange ()
		{
			int [] [] matrix = { new [] { 0 } };
			int [] [] expectedOutput = { new [] { 0 } };

			MatrixZeroConverter.SetZeroIfZero (matrix);
			Assert.That (matrix, Is.EqualTo (expectedOutput));
		}

		[Test]
		public void SetZeroIfZero_1x2MatrixNonZero_NoChange ()
		{
			int [] [] matrix = { new [] { 1, 2 } };
			int [] [] expectedOutput = { new [] { 1, 2 } };

			MatrixZeroConverter.SetZeroIfZero (matrix);
			Assert.That (matrix, Is.EqualTo (expectedOutput));
		}

		[Test]
		public void SetZeroIfZero_1x2MatrixWithOneZero_AllZero ()
		{
			int [] [] matrix = { new [] { 1, 0 } };
			int [] [] expectedOutput = { new [] { 0, 0 } };

			MatrixZeroConverter.SetZeroIfZero (matrix);
			Assert.That (matrix, Is.EqualTo (expectedOutput));
		}

		[Test]
		public void SetZeroIfZero_2x3MatrixWithOneZero_RowAndColZero ()
		{
			int [] [] matrix =
			{
				new[] { 1, 2, 0 },
				new[] { 4, 5, 6 }
			};

			int [] [] expectedOutput =
			{
				new[] { 0, 0, 0 },
				new[] { 4, 5, 0 }
			};

			MatrixZeroConverter.SetZeroIfZero (matrix);
			Assert.That (matrix, Is.EqualTo (expectedOutput));
		}
	}
}
