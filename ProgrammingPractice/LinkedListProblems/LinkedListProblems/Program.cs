using System;

namespace LinkedListProblems
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var generator = new LinkedListGenerator ();
			var loopFinder = new CircularLinkedListLoopFinder ();

			var circularLinkedList = generator.GenerateCircularLinkedList ();
			var loopStart = loopFinder.GetStartOfLoop (circularLinkedList);

			Console.WriteLine (loopStart);
		}
	}
}
	