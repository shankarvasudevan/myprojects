using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public static class LinkedListPrinter<T>
	{
		public static string Print(LinkedList<T> list)
		{
			string linkedListStr = "[";
			foreach (var node in list) 
			{
				linkedListStr += node.ToString ();
				linkedListStr += "->";
			}
			linkedListStr += "]";

			return linkedListStr;
		}
	}
}
