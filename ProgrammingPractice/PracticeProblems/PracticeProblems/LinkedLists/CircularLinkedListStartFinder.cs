using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public static class CircularLinkedListStartFinder
	{
		public static string Find(LinkedList<string> circularLinkedList)
		{
			HashSet<string> previousNodes = new HashSet<string>();
			LinkedListNode<string> curr = circularLinkedList.First;

			while (curr != null && !previousNodes.Contains (curr.Value)) 
			{
				previousNodes.Add (curr.Value);
				curr = curr.Next;
			}

			if (curr == null) 
			{
				return null;
			}

			return curr.Value;
		}
	}
}
