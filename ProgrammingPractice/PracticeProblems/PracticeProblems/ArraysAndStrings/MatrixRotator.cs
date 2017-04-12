using System;
namespace PracticeProblems
{
	public static class MatrixRotator
	{
		public static int[][] Rotate (int[][] matrix)
		{
			if (matrix == null) 
			{
				return null;
			}

			/*
			 * Overall Algorithm
			 * * Start at the top-right corner
			 * * Keep swapping values, moving counter-clockwise
			 * * Stop when you reach the top-right corner
			 * * Repeat n-1 times (where n=length of matrix)
			 */
			int n = matrix [0].Length;

			int rotateIndex = 0;
			while (rotateIndex < n / 2) 
			{
				RotateInternal (matrix, rotateIndex, n-2*rotateIndex);
				rotateIndex++;
			}

			return matrix;
		}

		private static int [] [] RotateInternal (int [] [] matrix, int start, int len)
		{
			int n = start+len;
			int counter = start;

			while (counter < n - 1) {
				// start at top right hand corner
				int x = start;
				int y = n - 1;

				// Top
				while (y > start) {
					Swap (matrix, Tuple.Create (x, y), Tuple.Create (x, y - 1));
					y--;
				}

				// Left
				while (x < n - 1) {
					Swap (matrix, Tuple.Create (x, y), Tuple.Create (x + 1, y));
					x++;
				}

				// Bottom
				while (y < n - 1) {
					Swap (matrix, Tuple.Create (x, y), Tuple.Create (x, y + 1));
					y++;
				}

				// Right
				while (x > start+1) {
					Swap (matrix, Tuple.Create (x, y), Tuple.Create (x - 1, y));
					x--;
				}

				counter++;
			}

			return matrix;
		}

		public static void PrintMatrix (int [] [] matrix)
		{
			int n = matrix [0].Length;
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < n; j++) {
					Console.Write ("{0},", matrix [i] [j]);
				}

				Console.WriteLine ();
			}
		}

		private static int [] [] Swap (int [] [] matrix, Tuple<int, int> a, Tuple<int, int> b)
		{
			int tmp = matrix [a.Item1] [a.Item2];
			matrix [a.Item1] [a.Item2] = matrix [b.Item1] [b.Item2];
			matrix [b.Item1] [b.Item2] = tmp;

			return matrix;
		}
	}
}
