using System;

namespace LinkedListProblems
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var generator = new LinkedListGenerator ();
			var printer = new LinkedListPrinter ();
			var adder = new IntLinkedListAdder ();

			IntNode num1 = generator.GenerateSinglyLinkedList (9, 9);
			IntNode num2 = generator.GenerateSinglyLinkedList (9, 9);

			printer.Print (num1);
			Console.WriteLine ("+");
			printer.Print (num2);

			Console.WriteLine ("=");
			IntNode result = adder.Add (num1, num2);

			printer.Print (result);
		}
	}
}
	