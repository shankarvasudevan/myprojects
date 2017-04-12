using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public static class LinkedListBuilder<T>
	{
		public static LinkedList<T> Build (IEnumerable<T> input)
		{
			LinkedList<T> linkedList = new LinkedList<T> ();

			foreach (T node in input) 
			{
				linkedList.AddLast (node);
			}

			return linkedList;
		}
	}
}
