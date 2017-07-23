using System;
namespace PracticeProblems
{
	public class NextNodeFinder
	{
		public TreeNode<int> NextNode(DoublyLinkedTreeNode<int> node)
		{
			if (node == null)
			{
				return null;
			}

			if (node.Parent == null)
			{
				return node.Right != null ? this.MinElement(node.Right) : node.Right;
			}

			// Left subtree
			if (node.Value < node.Parent.Value)
			{
				return node.Right != null ? node.Right : node.Parent;
			}

			if (node.Right != null)
			{
				return node.Right;
			}

			if (node.Parent.Parent == null)
			{
				return null;
			}

			return node.Parent.Value <= node.Parent.Parent.Value ? node.Parent.Parent : null;
		}

		// gets the minimum value in a subtree
		private TreeNode<int> MinElement(TreeNode<int> node)
		{
			if (node.Left == null)
			{
				return node;
			}

			return this.MinElement(node.Left);
		}
	}
}
