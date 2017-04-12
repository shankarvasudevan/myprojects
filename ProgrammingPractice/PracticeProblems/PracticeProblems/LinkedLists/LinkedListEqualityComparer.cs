using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public class LinkedListEqualityComparer : IEqualityComparer<LinkedList<int>>
	{
		public bool Equals (LinkedList<int> x, LinkedList<int> y)
		{
			if (x == null && y == null) 
			{
				return true;
			}

			if (x == null || y == null) 
			{
				return false;
			}

			LinkedListNode<int> iterX = x.First;
			LinkedListNode<int> iterY = y.First;

			Dictionary<int, int> xValues = new Dictionary<int, int> ();
			Dictionary<int, int> yValues = new Dictionary<int, int> ();

			while (iterX != null) 
			{
				if (xValues.ContainsKey[iterX.Value]) {
					xValues [iterX.Value]++;
				} else {
					xValues.Add (iterX.Value, 1);
				}

 				iterX = iterX.Next;
			}

			while (iterY != null) 
			{
				yValues [iterY.Value]++;
				iterY = iterY.Next;
			}

			// Compare keys
			var xKeys = xValues.Keys;
			var yKeys = yValues.Keys;

			if (xKeys.Count != yKeys.Count) 
			{
				return false;
			}

			foreach (var xKey in xKeys) 
			{
				if (xValues [xKey] != yValues [xKey]) 
				{
					return false;
				}
			}

			return true;
		}

		public int GetHashCode (LinkedList<int> obj)
		{
			throw new NotImplementedException ();
		}
	}
}
