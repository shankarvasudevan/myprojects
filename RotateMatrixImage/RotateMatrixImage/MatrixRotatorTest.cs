using System;
using NUnit.Framework;

namespace RotateMatrixImage
{
	[TestFixture]
	public class MatrixRotatorTest
	{
		[Test]
		public void Rotate_EmptyMatrix_ShouldReturnEmpty()
		{
			int[,] matrix = new int[0, 0];
			var rotator = new MatrixRotator ();
			matrix = rotator.Rotate (matrix, 0);

			Assert.That (matrix, Is.Empty);
		}

		[Test]
		public void Rotate_SingleElement_ShouldReturnSingleElement()
		{
			int[,] matrix = new int[1, 1] {{ 4 }}; 

			var rotator = new MatrixRotator ();
			matrix = rotator.Rotate (matrix, 0);

			Assert.That (matrix[0][0], Is.EqualTo(4));
		}

		[Test]
		public void Rotate_MultipleElements_ShouldRotateCorrectly()
		{
			int[,] matrix = new int[4, 4] 
			{
				{ 1, 2, 3, 4 },
				{ 5, 6, 7, 8 },
				{ 9, 10, 11, 12 },
				{ 13, 14, 15, 16 }
			}; 

			var rotator = new MatrixRotator ();
			matrix = rotator.Rotate (matrix, 0);

			int[,] expectedRotated = new int[4, 4] 
			{
				{ 13, 9, 5, 1 },
				{ 14, 10, 6, 2 },
				{ 15, 11, 7, 3 },
				{ 16, 12, 8, 4 }
			};

			Assert.That (matrix, Is.EquivalentTo (expectedRotated));
		}
	}
}

