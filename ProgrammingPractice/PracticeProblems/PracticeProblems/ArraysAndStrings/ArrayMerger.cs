using System;
namespace PracticeProblems
{
	public class ArrayMerger
	{
		public int Merge (int [] A)
		{
			if (A == null) {
				return 0;
			}

			int N = A.Length;

			if (N < 2) {
				return 0;
			}

			if (N == 2) {
				return A [0] + A [1];
			}

			Array.Sort (A);

			int latestMergeTime = 0;
			int totalMergeTime = 0;
			for (int i = 0; i < N; i++) {
				latestMergeTime += A [i];
				if (i > 0) {
					totalMergeTime += latestMergeTime;
				}
			}

			return totalMergeTime;
		}
	}
}
