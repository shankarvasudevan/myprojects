using System;

namespace LinkedListProblems
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Node original = GenerateSinglyLinkedList ();
			Console.WriteLine ("Original list:");
			new LinkedListPrinter().Print (original);

			Node elemToDelete = GetNthElement (original, 4);
			Console.WriteLine ("Now deleting {0}:{1}", elemToDelete.Id, elemToDelete.Data);

			new ElementDeleter ().Delete (elemToDelete);

			Console.WriteLine ("New list:");
			new LinkedListPrinter().Print (original);

		}

		public static Node GetNthElement(Node head, int n)
		{
			Node elem = head;
			for (int i = 0; i < n; i++) 
			{
				elem = elem.Next;
			}

			return elem;
		}

		public static Node GenerateSinglyLinkedList()
		{
			Node n1 = new Node { Id = 1, Data = "A" };
			Node n2 = new Node { Id = 2, Data = "B" };
			Node n3 = new Node { Id = 3, Data = "C" };
			Node n4 = new Node { Id = 4, Data = "D" };
			Node n5 = new Node { Id = 5, Data = "E" };
			Node n6 = new Node { Id = 6, Data = "F" };
			Node n7 = new Node { Id = 7, Data = "G" };
			Node n8 = new Node { Id = 8, Data = "H" };

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
	}
}
	