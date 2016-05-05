using System;

namespace LinkedListProblems
{
	public class LinkedListGenerator
	{
		public StringNode GenerateSinglyLinkedList(params string[] items)
		{
			StringNode head = null;
			StringNode prev = null;
			for (int i = 0; i < items.Length; i++) 
			{
				StringNode node = new StringNode 
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

		public StringNode GenerateCircularLinkedList()
		{
			var n1 = new StringNode { Data = "A" };
			var n2 = new StringNode { Data = "B" };
			var n3 = new StringNode { Data = "C" };
			var n4 = new StringNode { Data = "D" };
			var n5 = new StringNode { Data = "E" };

			n1.Next = n2;
			n2.Next = n3;
			n3.Next = n4;
			n4.Next = n5;
			n5.Next = n3;

			return n1;
		}
	}
}

