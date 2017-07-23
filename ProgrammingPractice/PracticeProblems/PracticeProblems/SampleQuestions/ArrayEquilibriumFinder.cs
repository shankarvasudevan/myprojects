using System;
namespace PracticeProblems.SampleQuestions
{
    public class ArrayEquilibriumFinder
    {
        public int Find(int[] A)
        {
            int eqIndex = -1;
            int[] forwardSum = new int[A.Length];
            int[] reverseSum = new int[A.Length];
            int i = 0;
            int j = A.Length - 1;

            while (i < A.Length && j >= 0)
            {
                int prevForwardSum = 0;
                int prevReverseSum = 0;

                if (i > 0)
                {
                    prevForwardSum = forwardSum[i - 1];
                }

                if (j < A.Length - 1)
                {
                    prevReverseSum = reverseSum[j + 1];
                }

                forwardSum[i] = prevForwardSum + A[i];
                reverseSum[j] = prevReverseSum + A[j];
            }

            return 0;
        }
    }
}
