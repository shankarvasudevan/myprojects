using System;

namespace LinkedListProblems
{
	public class Node
	{
		public int Id { get; set; }
		public Node Next { get; set; }

		public override string ToString ()
		{
			return string.Format ("{0}", this.Id);
		}
	}
}

