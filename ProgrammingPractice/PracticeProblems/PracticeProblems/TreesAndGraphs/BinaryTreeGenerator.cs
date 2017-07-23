using System;
namespace PracticeProblems
{
	public class BinaryTreeGenerator
	{
		/*
		 * Start with middle element (n/2)
		 * Generate left tree from elements (0, n/2 - 1)
		 * Generate right tree from elements (n/2 + 1, n-1)
		 */
		public TreeNode<int> Generate(int[] input)
		{
			if (input == null)
			{
				return null;
			}

			return this.GenerateTree(input, 0, input.Length);
		}

		private TreeNode<int> GenerateTree(int[] input, int fromIndex, int toIndex)
		{
			if (fromIndex == toIndex)
			{
				return null;
			}

			int n = toIndex - fromIndex;
			int rootIndex = fromIndex + (n / 2);

			TreeNode<int> root = new TreeNode<int>(input[rootIndex]);

			TreeNode<int> left = this.GenerateTree(input, fromIndex, rootIndex);
			TreeNode<int> right = this.GenerateTree(input, rootIndex + 1, toIndex);

			root.Left = left;
			root.Right = right;

			return root;
		}

	}
}
