using System;

namespace LinkedListProblems
{
	public class LinkedListPrinter
	{		
		public void Print(Node head)
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
	}
}

