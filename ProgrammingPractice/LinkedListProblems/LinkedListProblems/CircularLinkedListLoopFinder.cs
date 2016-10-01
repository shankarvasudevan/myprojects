using System;
using System.Collections.Generic;

namespace LinkedListProblems
{
	public class CircularLinkedListLoopFinder
	{
		public Node GetStartOfLoop(Node head)
		{
			List<Node> seenNodes = new List<Node>();
			Node tmp = head;
			while (tmp != null)
			{
				// if HashCode is implemented in Contains (using Unique data, then O(n), else O(n^2))
				if (seenNodes.Contains(tmp)) 
				{
					return tmp;
				}

				seenNodes.Add(tmp);
				tmp = tmp.Next;
			}

			return null;
		}
	}
}

