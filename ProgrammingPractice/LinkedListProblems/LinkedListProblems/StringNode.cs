using System;

namespace LinkedListProblems
{
	public class StringNode : Node
	{
		public string Data { get; set; }

		public override string ToString ()
		{
			return string.Format ("{0}", this.Data);
		}
	}
}

