using System;
namespace PracticeProblems
{
	public class BinaryTreeSubtreeChecker
	{
		public bool IsSubtree(TreeNode<int> t1, TreeNode<int> t2)
		{
			if (t1.Equals(t2))
			{
				return true;
			}

			string t1Infix = this.InfixString(t1);
			string t2Infix = this.InfixString(t2);

			return t1Infix.Contains(t2Infix);
		}

		private string InfixString(TreeNode<int> node)
		{
			if (node == null)
			{
				return string.Empty;
			}

			return string.Format(
				"{0}{1}{2}",
				this.InfixString(node.Left),
				node.Value,
				this.InfixString(node.Right));
		}
	}
}
