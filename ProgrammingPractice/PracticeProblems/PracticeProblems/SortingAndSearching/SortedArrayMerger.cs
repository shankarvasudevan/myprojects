using System;
namespace PracticeProblems.SortingAndSearching
{
    public class SortedArrayMerger
    {
        public int?[] Merge(int?[] a, int[] b)
        {
            /*
             * Algorithm:
             * - Go through each element of A and B
             * - If B[i] < A[i] then shift A down 1 and insert A[i] = B[i]
             */

            // A) 1,3,5,7,9
            // B) 2,4,6,8,10

            int aIter = 0;
            int bIter = 0;

            while (bIter < b.Length)
            {
                if (a[aIter] != null)
                {
                    int aVal = a[aIter].Value;
					if (aVal > b[bIter])
					{
						this.ShiftByOne(a, aIter);
						a[aIter] = b[bIter++];
					}
                }
                else
                {
                    a[aIter] = b[bIter++];
                }

                aIter++;
            }

            return a;
        }

        private void ShiftByOne(int?[] a, int fromIndex)
        {
            for (int i = a.Length - 1; i > fromIndex; i--)
            {
                a[i] = a[i - 1];
            }

            a[fromIndex] = null;
        }
    }
}
