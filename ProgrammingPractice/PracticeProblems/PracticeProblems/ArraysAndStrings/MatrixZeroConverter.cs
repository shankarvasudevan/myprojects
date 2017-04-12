using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public static class MatrixZeroConverter
	{
		public static void SetZeroIfZero (int [] [] matrix)
		{
			// error checking
			if (matrix == null) 
			{
				return;
			}

			int numRows = matrix.Length;
			int numCols = matrix[0].Length;

			List<int> rowsToSetZero = new List<int> ();
			List<int> colsToSetZero = new List<int> ();

			// loop through each cell and determine which rows, cols should be set to zero
			for (int row = 0; row < numRows; row++) 
			{
				for (int col = 0; col < numCols; col++) 
				{
					if (matrix [row] [col] == 0) 
					{
						rowsToSetZero.Add (row);
						colsToSetZero.Add (col);
					}
				}
			}

			// set the corresponding rows to zero
			foreach (int row in rowsToSetZero) 
			{
				SetRowToZero (matrix, row, numCols);
			}

			// set the corresponding cols to zero
			foreach (int col in colsToSetZero) 
			{
				SetColToZero (matrix, col, numRows);
			}
		}


		private static void SetRowToZero (int [] [] matrix, int row, int numCols)
		{
			//Console.WriteLine (string.Format ("SetRowToZero: {0}:{1}", row, numCols));
			for (int i = 0; i < numCols; i++) 
			{
				matrix [row] [i] = 0;
			}
		}

		private static void SetColToZero (int [] [] matrix, int col, int numRows)
		{
			//Console.WriteLine (string.Format ("SetColToZero: {0}:{1}", col, numRows));
			for (int i = 0; i < numRows; i++) {
				matrix [i] [col] = 0;
			}
		}
	}
}
