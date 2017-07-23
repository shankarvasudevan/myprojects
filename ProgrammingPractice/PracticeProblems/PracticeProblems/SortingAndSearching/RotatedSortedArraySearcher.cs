using System;
using System.Diagnostics.Contracts;

namespace PracticeProblems.SortingAndSearching
{
    public class RotatedSortedArraySearcher
    {
        public int Find(int[] rotatedSortedInput, int target)
        {
            int result = -1;
            int length = rotatedSortedInput.Length;

            var bsParams = this.GetBinarySearchParams(rotatedSortedInput, target, 0, length, out result);
            if (bsParams == null)
            {
                return result;
            }

            return BinarySearch(rotatedSortedInput, target, bsParams.Item1, bsParams.Item2);
        }

        private int BinarySearch(int[] input, int target, int start, int end)
        {
            int mid = (start + end) / 2;

            if (input[mid] == target)
            {
                return mid;
            }
            else if (input[mid] > target)
            {
                return BinarySearch(input, target, start, mid);
            }

            return BinarySearch(input, target, mid+1, end);
        }

        private Tuple<int,int> GetBinarySearchParams(int[] input, int target, int startIndex, int endIndex, out int result)
        {
            // Check if start mid or end equal the result
            int first = input[startIndex];
            if (first == target)
            {
                result = startIndex;
                return null;
            }

            int last = input[endIndex - 1];
            if (last == target)
            {
                result = endIndex-1;
                return null;
            }

            int n = endIndex - startIndex;
            int midIndex = startIndex + n / 2;
            int mid = input[midIndex];

            if (mid == target)
            {
                result = midIndex;
                return null;
            }

            // Case A: Completely sorted
            if (first <= mid && mid <= last)
            {
                if (mid > target)
                {
                    result = -1;
                    return Tuple.Create(startIndex, midIndex);
                }

                result = -1;
                return Tuple.Create(midIndex, endIndex);
            }

            // Case B: Rotated at the front
            if (first >= mid && mid <= last)
            {
                if (mid > target && last < target)
                {
                    return this.GetBinarySearchParams(input, target, startIndex, midIndex, out result);
                }

                result = -1;
                return Tuple.Create(midIndex, endIndex);
            }

            // Case C: Rotated at the end
            if (first <= mid && mid >= last)
            {
                if (mid > target && first < target)
                {
                    result = -1;
                    return Tuple.Create(startIndex, midIndex);
                }

                return this.GetBinarySearchParams(input, target, midIndex, endIndex, out result);
            }

            result = -1;
            return null;
        }
    }
}
