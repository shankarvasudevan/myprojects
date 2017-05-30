using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeProblems
{
	public class AdjacencyChecker
	{
		public int Check(int[] A)
		{
			int N = A.Length;

			List<Tuple<int, int>> values = new List<Tuple<int, int>> ();
			for (int i = 0; i < N; i++) {
				values.Add (Tuple.Create (i, A [i]));
			}

			Tuple<int, int> [] orderedValues = values
				.OrderBy (x => x.Item2)
				.ThenByDescending (x => x.Item1)
				.ToArray ();

			int furthestDistance = 0;
			for (int i = 0; i < N - 1; i++) {
				if (orderedValues [i].Item2 != orderedValues [i + 1].Item2) {
					int currentDistance = Math.Abs (
						orderedValues [i].Item1 - orderedValues [i + 1].Item1);

					if (currentDistance > furthestDistance) {
						furthestDistance = currentDistance;
					}
				}
			}

			return furthestDistance;
		}
	}
}
