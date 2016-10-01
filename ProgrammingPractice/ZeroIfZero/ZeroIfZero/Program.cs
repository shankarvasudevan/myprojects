using System;
using System.Collections.Generic;

namespace ZeroIfZero
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int m = 5;
			int n = 6;

			int[,] matrix = GenerateMatrix (m, n);

			Console.WriteLine ("Before");
			PrintMatrix (matrix);
			ZeroIfZero (matrix);
			Console.WriteLine ("After");
			PrintMatrix (matrix);
		}

		public static void ZeroIfZero(int[,] matrix)
		{
			int m = matrix.GetLength (0);
			int n = matrix.GetLength (1);

			List<int> zeroRows = new List<int> ();
			List<int> zeroCols = new List<int> ();

			for (int i = 0; i < m; i++) 
			{
				if (zeroRows.Contains (i)) 
				{
					continue;
				}

				for (int j = 0; j < n; j++) 
				{
					if (zeroCols.Contains (j)) 
					{
						continue;
					}

					if (matrix [i, j] == 0) 
					{
						zeroRows.Add (i);
						zeroCols.Add (j);
					}
				}
			}

			foreach (int row in zeroRows) 
			{
				SetRowToZero (matrix, row);
			}

			foreach (int col in zeroCols) 
			{
				SetColToZero (matrix, col);
			}
		}

		public static void SetRowToZero(int[,] matrix, int row)
		{
			int colLength = matrix.GetLength (1);

			for (int i = 0; i < colLength; i++) 
			{
				matrix [row, i] = 0;
			}
		}

		public static void SetColToZero(int[,] matrix, int col)
		{
			int rowLength = matrix.GetLength (0);

			for (int j = 0; j < rowLength; j++) 
			{
				matrix [j, col] = 0;
			}
		}

		public static void PrintMatrix(int[,] matrix)
		{
			Console.WriteLine ("--------------------------");
			for (int i=0; i < matrix.GetLength(0); i++)
			{
				for (int j=0; j < matrix.GetLength(1); j++)
				{
					Console.Write(string.Format("{0:D2} ", matrix[i,j]));
				}

				Console.WriteLine();
			}

			Console.WriteLine ("--------------------------");
		}

		public static int[,] GenerateMatrix(int m, int n)
		{
			int[,] matrix = new int[m, n];
			var rand = new Random ();

			for (int i = 0; i < m; i++) 
			{
				for (int j = 0; j < n; j++) 
				{
					matrix [i, j] = rand.Next (0, 9);
				}
			}

			return matrix;
		}
	}
}
