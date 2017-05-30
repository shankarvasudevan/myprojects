using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public class LinkedListNodeEqualityComparer<T> : IEqualityComparer<LinkedListNode<T>>
	{
		public bool Equals (LinkedListNode<T> x, LinkedListNode<T> y)
		{
			if (x == null && y == null) 
			{
				return true;
			}

			if (x == null || y == null) 
			{
				return false;
			}

			return x.Value.Equals(y.Value);
		}

		public int GetHashCode (LinkedListNode<T> obj)
		{
			return obj.GetHashCode ();
		}
	}
}
