using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public class RouteChecker
	{
		public bool RouteExists(GraphNode from, GraphNode to, List<GraphNode> visited)
		{
			if (from.Value == to.Value)
			{
				return true;
			}

			visited.Add(from);

			foreach (var node in from.ConnectedNodes)
			{
				if (visited.Contains(node))
				{
					continue;
				}

				if (this.RouteExists(node, to, visited))
				{
					return true;
				}
			}

			return false;
		}
	}
}
