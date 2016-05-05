using System;

namespace RemoveDuplicatesFromLinkedList
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Node head = GenerateSinglyLinkedList ();

			PrintLinkedList (head);
			RemoveDuplicates (head);
			PrintLinkedList (head);

		}

		public static void PrintLinkedList(Node head)
		{	
			Console.WriteLine ("------------------------");
			Node curr = head;

			while (curr != null) 
			{
				Console.Write ("{0} -> ", curr.Data);

				if (curr.Next == null) 
				{
					Console.Write ("NULL");
				}

				curr = curr.Next;
			}

			Console.WriteLine ();
			Console.WriteLine ("------------------------");
		}

		public static void RemoveDuplicates(Node head)
		{
			Node curr = head;
			Node prev = head;

			while (curr != null)
			{
				if (AlreadyExists (head, curr)) {
					prev.Next = curr.Next;
				} 
				else 
				{
					prev = curr;
				}

				curr = curr.Next;
			}
		}
			
		public static bool AlreadyExists(Node head, Node curr)
		{
			Node tmp = head;
			while (tmp.Id != curr.Id)
			{
				if (tmp.Data == curr.Data)
				{
					return true;
				}

				tmp = tmp.Next;
			}

			return false;
		}

		public static Node GenerateSinglyLinkedList()
		{
			Node n1 = new Node { Id = 1, Data = "cat" };
			Node n2 = new Node { Id = 2, Data = "rat" };
			Node n3 = new Node { Id = 3, Data = "fish" };
			Node n4 = new Node { Id = 4, Data = "dog" };
			Node n5 = new Node { Id = 5, Data = "rat" };
			Node n6 = new Node { Id = 6, Data = "eel" };
			Node n7 = new Node { Id = 7, Data = "cat" };
			Node n8 = new Node { Id = 8, Data = "dog" };

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

	public class Node
	{
		public int Id { get; set; }
		public string Data { get; set; }
		public Node Next { get; set; }
	}
}
