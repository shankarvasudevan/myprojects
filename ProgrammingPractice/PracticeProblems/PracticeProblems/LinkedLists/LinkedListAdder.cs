using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public static class LinkedListAdder
	{
		public static LinkedList<int> Add (LinkedList<int> first, LinkedList<int> second)
		{
			LinkedList<int> result = new LinkedList<int>();
			int currentCarry = 0;

			LinkedListNode<int> firstIter = first.First;
			LinkedListNode<int> secondIter = second.First;

			while (firstIter != null || secondIter != null) 
			{
				int firstIterValue = firstIter != null ? firstIter.Value : 0;
				int secondIterValue = secondIter != null ? secondIter.Value : 0;

				int addResult = firstIterValue + secondIterValue + currentCarry;

				int nextNodeValue = addResult % 10;
				currentCarry = (int)addResult / 10;

				result.AddLast (nextNodeValue);

				// move the iterator
				if (firstIter != null) 
				{
					firstIter = firstIter.Next;
				}

				if (secondIter != null) 
				{
					secondIter = secondIter.Next;
				}
			}

			if (currentCarry > 0) 
			{
				result.AddLast (currentCarry);
			}

			return result;
		}
	}
}
