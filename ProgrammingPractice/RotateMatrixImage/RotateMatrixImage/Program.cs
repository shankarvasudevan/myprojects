using System;

namespace RotateMatrixImage
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 4;
			int[,] matrix = GenerateMatrix (n);

			Console.WriteLine ("Original");
			PrintMatrix (matrix);

			matrix = new MatrixRotator ().Rotate (matrix, n);
				
			Console.WriteLine ("Rotated");
			PrintMatrix(matrix);			
		}

		public static int[,] GenerateMatrix(int size)
		{
			int[,] matrix = new int[size, size];
			var generator = new Random ();

			for (int i = 0; i < size; i++) 
			{
				for (int j = 0; j < size; j++) 
				{
					matrix [i, j] = generator.Next (1, 99);	
				}
			}

			return matrix;
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

	}
}
