using System;

namespace LinkedListProblems
{
	public class IntNode : Node
	{
		public int Data { get; set; }

		public override string ToString ()
		{
			return string.Format ("{0}", this.Data);
		}
	}
}

