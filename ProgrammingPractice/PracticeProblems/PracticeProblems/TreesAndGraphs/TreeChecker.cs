using System;
namespace PracticeProblems
{
	public class TreeChecker
	{
		public bool IsBalanced<T>(TreeNode<T> root)
		{
			int maxDepth = this.MaxDepth(root);
			int minDepth = this.MinDepth(root);

			return Math.Abs(maxDepth - minDepth) <= 1;
		}

		public int MaxDepth<T>(TreeNode<T> node)
		{
			if (node == null)
			{
				return 0;
			}

			return 1 + Math.Max(this.MaxDepth(node.Left), this.MaxDepth(node.Right));
		}

		public int MinDepth<T>(TreeNode<T> node)
		{
			if (node == null)
			{
				return 0;
			}

			return 1 + Math.Min(this.MinDepth(node.Left), this.MinDepth(node.Right));
		}

	}
}
