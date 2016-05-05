using System;

namespace LinkedListProblems
{
	public class LinkedListReader
	{
		public Node GetNthElement(Node head, int n)
		{
			Node elem = head;
			for (int i = 0; i < n; i++) 
			{
				elem = elem.Next;
			}

			return elem;
		}
	}
}

