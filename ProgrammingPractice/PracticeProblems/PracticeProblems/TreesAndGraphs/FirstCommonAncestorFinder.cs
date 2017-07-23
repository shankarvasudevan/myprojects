using System;
namespace PracticeProblems
{
	public class FirstCommonAncestorFinder
	{
		public TreeNode<int> Find(TreeNode<int> root, TreeNode<int> first, TreeNode<int> second)
		{
			if (first.Equals(root) || second.Equals(root))
			{
				return root;
			}

			var firstParent = this.FindParent(root, first);
			var secondParent = this.FindParent(root, second);

			while (!firstParent.Equals(secondParent))
			{
				if (firstParent.Equals(second))
				{
					return second;
				}

				if (secondParent.Equals(first))
				{
					return first;
				}

				firstParent = this.FindParent(root, firstParent);
				secondParent = this.FindParent(root, secondParent);
			}

			return firstParent;
		}

		private TreeNode<int> FindParent(TreeNode<int> root, TreeNode<int> target)
		{
			if (root == null || root.Equals(target))
			{
				return root;
			}

			if (root.Left != null && root.Left.Equals(target))
			{
				return root;
			}

			if (root.Right != null && root.Right.Equals(target))
			{
				return root;
			}

			var leftResult = this.FindParent(root.Left, target);
			if (leftResult != null)
			{
				return leftResult;
			}

			return this.FindParent(root.Right, target);
		}
	}
}
