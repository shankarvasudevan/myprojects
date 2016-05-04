using System;

namespace RotateMatrixImage
{
	public class MatrixRotator
	{
		public MatrixRotator ()
		{
		}

		public int[,] Rotate(int[,] matrix, int size)
		{
			int rightEdge = size-1;
			int leftEdge = 0;

			while (rightEdge - leftEdge > 0) 
			{
				for (int i = leftEdge; i < rightEdge; i++) 
				{
					int top = matrix [leftEdge, i];
					int right = matrix [i, rightEdge];
					int bottom = matrix [rightEdge, rightEdge - i];
					int left = matrix [rightEdge - i, leftEdge];

					// rotate 90 degrees clockwise
					matrix [leftEdge, i] = left;
					matrix [i, rightEdge] = top;
					matrix [rightEdge, rightEdge - i] = right;
					matrix [rightEdge - i, leftEdge] = bottom;
				}

				leftEdge += 1;
				rightEdge -= 1;
			}

			return matrix;
		}
	}
}

