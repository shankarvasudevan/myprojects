using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class NextNodeFinderTest
	{
		private NextNodeFinder finder;

		[SetUp]
		public void Setup()
		{
			this.finder = new NextNodeFinder();
		}

		[Test]
		public void NextNode_EmptyTree_ReturnsNull()
		{
			Assert.That(this.finder.NextNode(null), Is.Null);
		}

		[Test]
		public void NextNode_SingleElementTree_ReturnsNull()
		{
			var root = new DoublyLinkedTreeNode<int>(1);
			Assert.That(this.finder.NextNode(root), Is.Null);
		}

		[Test]
		public void NextNode_TreeDepthTwo_ReturnsCorrectNextNode()
		{
			var one = new DoublyLinkedTreeNode<int>(1);
			var two = new DoublyLinkedTreeNode<int>(2);
			var three = new DoublyLinkedTreeNode<int>(3);

			two.Left = one;
			one.Parent = two;

			two.Right = three;
			three.Parent = two;

			Assert.That(this.finder.NextNode(one), Is.EqualTo(two));
			Assert.That(this.finder.NextNode(two), Is.EqualTo(three));
			Assert.That(this.finder.NextNode(three), Is.Null);
		}

		[Test]
		public void NextNode_UnbalancedLeftTree_ReturnsCorrectNextNode()
		{
			var one = new DoublyLinkedTreeNode<int>(1);
			var two = new DoublyLinkedTreeNode<int>(2);
			var three = new DoublyLinkedTreeNode<int>(3);

			three.Left = two;
			two.Parent = three;

			two.Left = one;
			one.Parent = two;

			Assert.That(this.finder.NextNode(one), Is.EqualTo(two));
			Assert.That(this.finder.NextNode(two), Is.EqualTo(three));
			Assert.That(this.finder.NextNode(three), Is.Null);
		}

		[Test]
		public void NextNode_UnbalancedRightTree_ReturnsCorrectNextNode()
		{
			var one = new DoublyLinkedTreeNode<int>(1);
			var two = new DoublyLinkedTreeNode<int>(2);
			var three = new DoublyLinkedTreeNode<int>(3);

			one.Right = two;
			two.Parent = one;

			two.Right = three;
			three.Parent = two;

			Assert.That(this.finder.NextNode(one), Is.EqualTo(two));
			Assert.That(this.finder.NextNode(two), Is.EqualTo(three));
			Assert.That(this.finder.NextNode(three), Is.Null);
		}

		[Test]
		public void NextNode_TreeDepthThree_ReturnsCorrectNextNode()
		{
			var one = new DoublyLinkedTreeNode<int>(1);
			var two = new DoublyLinkedTreeNode<int>(2);
			var three = new DoublyLinkedTreeNode<int>(3);
			var four = new DoublyLinkedTreeNode<int>(4);
			var five = new DoublyLinkedTreeNode<int>(5);
			var six = new DoublyLinkedTreeNode<int>(6);
			var seven = new DoublyLinkedTreeNode<int>(7);

			// level 2
			four.Left = two;
			two.Parent = four;

			four.Right = six;
			six.Parent = four;

			// level 3
			two.Left = one;
			one.Parent = two;

			two.Right = three;
			three.Parent = two;

			six.Left = five;
			five.Parent = six;

			six.Right = seven;
			seven.Parent = six;

			Assert.That(this.finder.NextNode(one), Is.EqualTo(two));
			Assert.That(this.finder.NextNode(two), Is.EqualTo(three));
			Assert.That(this.finder.NextNode(three), Is.EqualTo(four));
			Assert.That(this.finder.NextNode(four), Is.EqualTo(five));
			Assert.That(this.finder.NextNode(five), Is.EqualTo(six));
			Assert.That(this.finder.NextNode(six), Is.EqualTo(seven));
			Assert.That(this.finder.NextNode(seven), Is.Null);
		}
	}
}
