using System;
namespace PracticeProblems.SortingAndSearching
{
    public class SortedSpacedArraySearcher
    {
        public int Find(string[] input, string word)
        {
            if (input == null)
            {
                return -1;
            }

            return SpacedBinarySearch(input, word, 0, input.Length);
        }

        private int SpacedBinarySearch(string[] input, string target, int start, int end)
        {
            if (end-start < 1)
            {
                return -1;
            }

            if (input.Length == 1)
            {
                if (!string.Equals(input[0], target, StringComparison.OrdinalIgnoreCase))
                {
                    return -1;
                }

                return 0;
            }

            // Find the midpoint
            int mid = (start + end) / 2;

            // Find next word
            int nextWordIndex = mid;
            while (nextWordIndex < end && input[nextWordIndex] == "")
            {
                nextWordIndex++;
            }

            if (nextWordIndex == end || IsBefore(target, input[nextWordIndex]))
            {
                return SpacedBinarySearch(input, target, start, mid);
            }

			if (string.Equals(input[nextWordIndex], target, StringComparison.OrdinalIgnoreCase))
			{
				return nextWordIndex;
			}

			return SpacedBinarySearch(input, target, nextWordIndex+1, end);

        }

		// returns true if a is before b
		private bool IsBefore(string a, string b)
		{
			a = a.ToLower();
			b = b.ToLower();

			for (int i = 0; i < a.Length && i < b.Length; i++)
			{
				if (a[i] >= b[i])
				{
					return false;
				}
			}

			return a.Length <= b.Length;
		}
    }
}
