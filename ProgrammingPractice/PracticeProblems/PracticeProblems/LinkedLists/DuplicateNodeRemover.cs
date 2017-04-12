using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeProblems
{
	public static class DuplicateNodeRemover
	{
		public static LinkedList<int> RemoveWithBuffer(LinkedList<int> original)
		{
			LinkedList<int> withoutDuplicates = new LinkedList<int> ();
			List<int> existingNodes = new List<int> ();

			LinkedListNode<int> iter = original.First;

			while (iter != null) 
			{
				if (!existingNodes.Contains (iter.Value)) 
				{
					withoutDuplicates.AddLast (iter.Value);
					existingNodes.Add (iter.Value);
				}

				iter = iter.Next;
			}

			return withoutDuplicates;
		}

		public static LinkedList<int> RemoveWithoutBuffer (LinkedList<int> original)
		{
			LinkedListNode<int> firstIter = original.First;

			if (!original.Any ()) 
			{
				return original;
			}

			while (firstIter != null) 
			{
				LinkedListNode<int> secondIter = original.First;
				bool exists = false;
				while (secondIter != null) 
				{
					if (firstIter.Value == secondIter.Value) {
						if (!exists) {
							exists = true;
							secondIter = secondIter.Next;
						} else {
							LinkedListNode<int> tmp = secondIter;
							secondIter = secondIter.Next;
							original.Remove (tmp.Value);
						}
					} else {
						secondIter = secondIter.Next;
					}
				}

				firstIter = firstIter.Next;
			}

			return original;
		}
	}
}
