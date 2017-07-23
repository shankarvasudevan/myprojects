using System;
namespace PracticeProblems.SortingAndSearching
{
    public class SortedMatrixSearcher
    {
        public Tuple<int,int> Find(int[,] matrix, int target)
        {
            if (matrix == null)
            {
                return null;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == target)
                    {
                        return Tuple.Create(i, j);
                    }
                }    
            }

            return null;
        }
    }
}
