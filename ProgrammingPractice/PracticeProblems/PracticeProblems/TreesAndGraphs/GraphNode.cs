using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public class GraphNode : IEquatable<GraphNode>
	{
		public GraphNode(string value)
		{
			this.Value = value;
			this.ConnectedNodes = new List<GraphNode>();
		}

		public string Value { get; set; }
		public List<GraphNode> ConnectedNodes { get; set; }

		public bool Equals(GraphNode other)
		{
			return this.Value == other.Value;
		}

		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}
	}
}
