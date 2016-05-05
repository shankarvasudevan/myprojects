using System;

namespace LinkedListProblems
{
	public class LinkedListGenerator
	{
		public StringNode GenerateSinglyLinkedList(params string[] items)
		{
			StringNode n1 = new StringNode { Id = 1, Data = "A" };
			StringNode n2 = new StringNode { Id = 2, Data = "B" };
			StringNode n3 = new StringNode { Id = 3, Data = "C" };
			StringNode n4 = new StringNode { Id = 4, Data = "D" };
			StringNode n5 = new StringNode { Id = 5, Data = "E" };
			StringNode n6 = new StringNode { Id = 6, Data = "F" };
			StringNode n7 = new StringNode { Id = 7, Data = "G" };
			StringNode n8 = new StringNode { Id = 8, Data = "H" };

			n1.Next = n2;
			n2.Next = n3;
			n3.Next = n4;
			n4.Next = n5;
			n5.Next = n6;
			n6.Next = n7;
			n7.Next = n8;
			n8.Next = null;

			return n1;
		}

		public IntNode GenerateSinglyLinkedList(params int[] items)
		{
			IntNode head = null;
			IntNode prev = null;
			for (int i = 0; i < items.Length; i++) 
			{
				IntNode node = new IntNode 
				{
					Id = i,
					Data = items [i],
					Next = null
				};

				if (prev != null) 
				{
					prev.Next = node;
				} 
				else 
				{
					head = node;
				}
					
				prev = node;
			}

			return head;
		}
	}
}

