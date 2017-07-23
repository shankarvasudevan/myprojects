using System;
namespace PracticeProblems
{
	public class TreeNode<T> : IEquatable<TreeNode<T>>
	{
		public TreeNode(T value)
		{
			this.Value = value;
		}
		
		public T Value { get; private set; }

		public TreeNode<T> Left { get; set; }

		public TreeNode<T> Right { get; set; }

		public bool Equals(TreeNode<T> other)
		{
			if (other == null)
			{
				return false;
			}

			return this.Value.Equals(other.Value);
		}

		public override string ToString()
		{
			return string.Format("[TreeNode: Value={0}]", this.Value);
		}
	}
}
