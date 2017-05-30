using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeProblems
{
	public static class NthToLastLinkedListElementFinder
	{
		public static LinkedListNode<int> Find(LinkedList<int> linkedList, int n)
		{
			if (!linkedList.Any ()) 
			{
				return null;
			}

			int count = 0;
			LinkedListNode<int> countIter = linkedList.First;
			while (countIter != null) 
			{
				countIter = countIter.Next;
				count++;
			}

			int target = count - n;
			LinkedListNode<int> targetIter = linkedList.First;

			for (int i = 0; i < target; i++) 
			{
				targetIter = targetIter.Next;
			}

			return targetIter;
		}
	}
}
