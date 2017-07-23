using System;
namespace PracticeProblems.SortingAndSearching
{
    public class InPlaceEfficientSorter
    {
        public string[] Sort(string[] input)
        {
            this.MergeSort(input, 0, input.Length);
            return input;
        }

        private void MergeSort(string[] input, int start, int end)
        {
            if (end-start <= 1)
            {
                return;
            }

            int mid = (start + end) / 2;
            MergeSort(input, start, mid);
            MergeSort(input, mid + 1, end);

            Merge(input, start, mid, end);

        }

        // Merging lists A and B
        private void Merge(string[] input, int start, int mid, int end)
        {
            int i = start;
            int j = mid+1;

            while (i < end && i <= j)
            {
                if (IsBefore(input[j], input[i]))
                {
                    AddBefore(input, j, i);
                    j++;
                }

                i++;
            }
        }

        private void AddBefore(string[] input, int elemIndex, int destIndex)
        {
            string elem = input[elemIndex];
            for (int i = elemIndex; i > destIndex; i++)
            {
                input[i] = input[i - 1];
            }
            input[destIndex] = elem;
        }

        private void QuickSort(string[] input, int startIndex, int endIndex)
        {
            // Recursion exit
            if (endIndex-startIndex <= 1)
            {
                return;
            }

            // 1. Select Initial Pivot
            int pivot = (startIndex + endIndex) / 2;

            // 2a. Partition elements to the right of pivot that are greater than pivot
            for (int i = startIndex; i < pivot; i++)
            {
                if (!IsBefore(input[i], input[pivot]))
                {
                    AddAfterPivot(input, i, pivot);
                    pivot--;
                }
            }

            // 2b. Partition elements to the left of pivot that are less than pivot
            for (int i = pivot + 1; i < endIndex; i++)
            {
                if (IsBefore(input[i], input[pivot]))
                {
                    AddBeforePivot(input, i, pivot);
                    pivot++;
                }
            }

            // Repeat
            QuickSort(input, startIndex, pivot);
            QuickSort(input, pivot + 1, endIndex);
        }

        // returns true if a is before b
        private bool IsBefore(string a, string b)
        {
            a = a.ToLower();
            b = b.ToLower();

            for (int i= 0; i < a.Length && i < b.Length; i++)
            {
                if (a[i] >= b[i])
                {
                    return false;
                }
            }

            return a.Length <= b.Length;
        }

        private void AddAfterPivot(string[] input, int elemIndex, int pivotIndex)
        {
            string elem = input[elemIndex];

            for (int i = elemIndex;  i < pivotIndex; i++)
            {
                input[i] = input[i + 1];
            }

            input[pivotIndex] = elem;
        }

        private void AddBeforePivot(string[] input, int elemIndex, int pivotIndex)
        {
            string elem = input[elemIndex];

            for (int i = elemIndex; i > pivotIndex; i--)
            {
                input[i] = input[i - 1];
            }

            input[pivotIndex] = elem;
        }
    }   
}
