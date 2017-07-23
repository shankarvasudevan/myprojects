using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class BinaryTreeSubtreeCheckerTest
	{
		private BinaryTreeSubtreeChecker subtreeChecker;

		[SetUp]
		public void Setup()
		{
			this.subtreeChecker = new BinaryTreeSubtreeChecker();
		}

		[Test]
		public void IsSubtree_BothTreesSame_ReturnsTrue()
		{
			var tree = new TreeNode<int>(1);
			Assert.That(this.subtreeChecker.IsSubtree(tree, tree), Is.True);
		}

		[Test]
		public void IsSubtree_TreeDepthTwo_ReturnsCorrectSubtrees()
		{
			var one = new TreeNode<int>(1);
			var two = new TreeNode<int>(2);
			var three = new TreeNode<int>(3);

			one.Left = two;
			one.Right = three;

			Assert.That(this.subtreeChecker.IsSubtree(one, two), Is.True);
			Assert.That(this.subtreeChecker.IsSubtree(one, three), Is.True);
			Assert.That(this.subtreeChecker.IsSubtree(two, three), Is.False);
		}

		[Test]
		public void IsSubtree_TreeDepthThree_ReturnsCorrectSubtrees()
		{
			var one = new TreeNode<int>(1);
			var two = new TreeNode<int>(2);
			var three = new TreeNode<int>(3);
			var four = new TreeNode<int>(4);
			var five = new TreeNode<int>(5);
			var six = new TreeNode<int>(6);
			var seven = new TreeNode<int>(7);

			one.Left = two;
			one.Right = three;

			two.Left = four;
			two.Right = five;

			three.Left = six;
			three.Right = seven;

			Assert.That(this.subtreeChecker.IsSubtree(one, two), Is.True);
			Assert.That(this.subtreeChecker.IsSubtree(one, three), Is.True);
			Assert.That(this.subtreeChecker.IsSubtree(one, four), Is.True);
			Assert.That(this.subtreeChecker.IsSubtree(one, five), Is.True);
			Assert.That(this.subtreeChecker.IsSubtree(one, six), Is.True);
			Assert.That(this.subtreeChecker.IsSubtree(one, seven), Is.True);

			Assert.That(this.subtreeChecker.IsSubtree(two, one), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(two, three), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(two, four), Is.True);
			Assert.That(this.subtreeChecker.IsSubtree(two, five), Is.True);
			Assert.That(this.subtreeChecker.IsSubtree(two, six), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(two, seven), Is.False);

			Assert.That(this.subtreeChecker.IsSubtree(three, one), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(three, two), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(three, four), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(three, five), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(three, six), Is.True);
			Assert.That(this.subtreeChecker.IsSubtree(three, seven), Is.True);

			Assert.That(this.subtreeChecker.IsSubtree(four, one), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(four, two), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(four, three), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(four, five), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(four, six), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(four, seven), Is.False);

			Assert.That(this.subtreeChecker.IsSubtree(five, one), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(five, two), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(five, three), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(five, four), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(five, six), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(five, seven), Is.False);

			Assert.That(this.subtreeChecker.IsSubtree(six, one), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(six, two), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(six, three), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(six, four), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(six, five), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(six, seven), Is.False);

			Assert.That(this.subtreeChecker.IsSubtree(seven, one), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(seven, two), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(seven, three), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(seven, four), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(seven, five), Is.False);
			Assert.That(this.subtreeChecker.IsSubtree(seven, six), Is.False);
		}
	}
}
