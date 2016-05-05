using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
	public class Sorter
	{
		public int[] MergeSort(int[] numbers)
		{
			if (numbers.Length == 1) 
			{
				return numbers;
			}

			int len = numbers.Length;
			int split = len / 2;

			int[] subListA = new int[split];
			int[] subListB = new int[len - split];

			for (int i = 0; i < split; i++) 
			{
				subListA [i] = numbers [i];
			}

			for (int i = split; i < len; i++) 
			{
				subListB [i - split] = numbers [i];
			}

			int[] sortedSubListA = MergeSort (subListA);
			int[] sortedSubListB = MergeSort (subListB);

			int[] resultSubList = new int[len];

			int a = 0;
			int b = 0;
			for (int i = 0; i < len; i++) 
			{
				if (a == sortedSubListA.Length) 
				{
					resultSubList [i] = sortedSubListB [b++];
					continue;
				}

				if (b == sortedSubListB.Length) 
				{
					resultSubList [i] = sortedSubListA [a++];
					continue;
				}
					
				if (sortedSubListA [a] < sortedSubListB [b]) 
				{
					resultSubList [i] = sortedSubListA [a++];
				} 
				else 
				{
					resultSubList [i] = sortedSubListB [b++];
				}
			}

			return resultSubList;
		}

		public int[] BucketSort(int[] numbers)
		{
			// Create buckets
			List<int>[] buckets = new List<int>[]
			{
				new List<int> (),
				new List<int> (),
				new List<int> (),
				new List<int> (),
				new List<int> ()
			};

			// Scatter
			for (int i = 0; i < numbers.Length; i++) 
			{
				int val = numbers [i];
				if (val < 3) 
				{
					buckets [0].Add (val);
				} 
				else if (val >= 3 && val < 6) 
				{
					buckets [1].Add (val);
				} 
				else if (val >= 6 && val < 9) 
				{
					buckets [2].Add (val);
				} 
				else if (val >= 9 && val < 12) 
				{
					buckets [3].Add (val);
				} 
				else 
				{
					buckets [4].Add (val);
				}
			}

			// Sort each bucket
			for (int i = 0; i < buckets.Length; i++) 
			{
				buckets [i] = QuickSort (buckets [i].ToArray ()).ToList ();
			}

			// Read back each bucket
			int index = 0;
			for (int i = 0; i < buckets.Length; i++) 
			{
				int[] bucketItems = buckets [i].ToArray ();
				for (int j = 0; j < bucketItems.Length; j++) 
				{
					numbers [index++] = bucketItems [j];
				}
			}

			return numbers;
		}

		public int[] QuickSort(int[] numbers)
		{
			QuickSortRecursive (numbers, 0, numbers.Length-1);
			return numbers;
		}

		private void QuickSortRecursive(int[] numbers, int from, int to)
		{
			if (from >= to) 
			{
				return;
			}

			int wall = from;
			int pivot = to;

			for (int curr = from; curr < pivot; curr++) 
			{
				if (numbers [curr] < numbers [pivot]) 
				{
					Swap (numbers, curr, wall);
					wall++;
				}
			}

			if (wall < pivot) 
			{
				Swap (numbers, wall, pivot);
				wall++;
			}

			QuickSortRecursive (numbers, from, wall-1);
			QuickSortRecursive (numbers, wall, to);
		}

		public void Swap(int[] numbers, int i, int j)
		{
			int tmp = numbers [i];
			numbers [i] = numbers [j];
			numbers [j] = tmp;
		}
	}
}

