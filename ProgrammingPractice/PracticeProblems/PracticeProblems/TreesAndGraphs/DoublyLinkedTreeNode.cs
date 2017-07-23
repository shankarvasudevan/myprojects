using System;
namespace PracticeProblems
{
	public class DoublyLinkedTreeNode<T> : TreeNode<T>
	{
		public DoublyLinkedTreeNode(T value) : base(value) { }
		public DoublyLinkedTreeNode<T> Parent { get; set; }
	}
}
