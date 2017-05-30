using System;
namespace PracticeProblems
{
	public class BattleshipSinker
	{
		private const int AsciiValCapitalA = 65;
		private const int AsciiValZero = 48;

		public string SinksAndHits (int N, string S, string T)
		{
			// initialise the board to 0
			int [,] board = new int [N,N];
			for (int i = 0; i < N; i++) 
			{
				for (int j = 0; j < N; j++) 
				{
					board [i, j] = 0;
				}
			}

			// mark all the hits (T) as 1
			string [] hits = T.Split (' ');
			foreach (string hit in hits) 
			{
				Tuple<int, int> hitLoc = GetCoordinates (hit);
				board [hitLoc.Item1, hitLoc.Item2] = 1;
			}

			// go through each ship and see what has been hit/sunk/none
			int numHits = 0;
			int numSinks = 0;
			string [] ships = S.Split (',');
			foreach (string s in ships) 
			{
				string ship = s.TrimStart (' ');
				string [] shipCorners = ship.Split (' ');
				Tuple<int, int> topLeft = GetCoordinates (shipCorners [0]);
				Tuple<int, int> bottomRight = GetCoordinates (shipCorners [1]);

				ShipState shipState = IsShipHitOrSunk (board, topLeft.Item1, topLeft.Item2, bottomRight.Item1, bottomRight.Item2);

				if (shipState == ShipState.Sunk) 
				{
					numSinks++;
				} 
				else if (shipState == ShipState.Hit) 
				{
					numHits++;
				}
			}

			string result = string.Format ("{0},{1}", numSinks, numHits);
			return result;
		}

		private ShipState IsShipHitOrSunk (int [,] board, int topLeftRow, int topLeftCol, int bottomRightRow, int bottomRightCol)
		{
			int numShips = 0;
			int numHits = 0;
			for (int row = topLeftRow; row <= bottomRightRow; row++) 
			{
				for (int col = topLeftCol; col <= bottomRightCol; col++) 
				{
					numShips++;
					if (board [row, col] == 1) 
					{
						numHits++;
					}
				}
			}

			if (numHits == numShips) 
			{
				return ShipState.Sunk;
			}

			if (numHits > 0) 
			{
				return ShipState.Hit;
			}

			return ShipState.None;
		}

		private Tuple<int, int> GetCoordinates (string cellDesc)
		{
			int len = cellDesc.Length;
			char [] cellDescArr = cellDesc.ToCharArray ();
			int col = (int)cellDescArr [len-1] - AsciiValCapitalA;

			int row = 0;
			if (len == 2) 
			{
				row = (int)Char.GetNumericValue (cellDescArr [0]) - 1;
			} 
			else 
			{
				int rowTensDigit = (int)Char.GetNumericValue (cellDescArr [0]);
				int rowOnesDigit = (int)Char.GetNumericValue (cellDescArr [1]);
				row = rowTensDigit * 10 + rowOnesDigit - 1;
			}
				
	 		return Tuple.Create (row, col);
		}

		private enum ShipState
		{
			None,
			Hit,
			Sunk
		}
	}
}
