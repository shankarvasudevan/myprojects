using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public class TreePrinter
	{
		public string BfsPrint(TreeNode<int> node)
		{
			string treeString = string.Empty;
			Queue<TreeNode<int>> searchQueue = new Queue<TreeNode<int>>();

			TreeNode<int> curr = node;
			searchQueue.Enqueue(curr);
			while (searchQueue.Count != 0)
			{
				curr = searchQueue.Dequeue();
				treeString += curr.Value + "-";

				if (curr.Left != null)
				{
					searchQueue.Enqueue(curr.Left);
				}

				if (curr.Right != null)
				{
					searchQueue.Enqueue(curr.Right);
				}
			}

			return treeString;
		}
	}
}
