using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class SimpleWaitPulse
{
	static void Main()
	{
         int[] arr1 = new int[] { 10, 2, 5, 1, 8, 20 };
         int[] arr2 = new int[] { 5, 10, 18, 7, 8, 3 };
         int[] arr3 = new int[] { 10, 20, 30 };
         Console.WriteLine("MaxTriplet = {0}", GetMaxTriplet(arr2));
    }

    static int GetMaxTriplet(int[] A)
    {
        if (A.Length < 3)
        {
            return -1;
        }

        Array.Sort(A); // O(n*log(n))

        int maxTriplet = -1;
        int currTriplet = -1;
        int count = 0;
        for (int i = A.Length - 1; i >= 0; i--)
        {
            if (i == A.Length-1)
            {
                count++;
                currTriplet = A[i];
                continue;
            }

            if (A[i]*2 <= A[i+1])
            {
                count = 1;
                currTriplet = A[i];
                continue;
            }

			count++;
			currTriplet += A[i];

            if (count == 3)
            {
                if (A[i] + A[i+1] <= A[i+2])
                {
                    count = 2;
                    currTriplet = A[i+1] + A[i];
                    continue;
                }

                if (currTriplet > maxTriplet)
                {
                    maxTriplet = currTriplet;
                }

                count = 0;
                currTriplet = 0;
            }
        }

        return maxTriplet;
    }


    static int GetMaxSlice(int[] arr)
    {
        int maxSliceLen = 1;
        int maxSliceStart = 0;
        int currSliceLen = 1;
        int currSliceStart = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] <= arr[i-1])
            {
                if (currSliceLen > maxSliceLen)
                {
                    maxSliceStart = currSliceStart;
                    maxSliceLen = currSliceLen;    
                }

                currSliceStart = i;
                currSliceLen = 1;
            }
            else
            {
                currSliceLen++;
            }
        }

        return maxSliceStart;
    }
}
