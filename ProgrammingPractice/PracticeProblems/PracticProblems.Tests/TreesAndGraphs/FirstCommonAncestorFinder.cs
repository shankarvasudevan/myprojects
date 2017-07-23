using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class FirstCommonAncestorFinderTest
	{
		private FirstCommonAncestorFinder finder;

		[SetUp]
		public void Setup()
		{
			this.finder = new FirstCommonAncestorFinder();
		}

		[Test]
		public void Find_TreeDepthOne_ReturnsSingleElement()
		{
			var one = new TreeNode<int>(1);
			Assert.That(this.finder.Find(one, one, one), Is.EqualTo(one));
		}

		[Test]
		public void Find_TreeDepthTwo_ReturnsCorrectAncestor()
		{
			var one = new TreeNode<int>(1);
			var two = new TreeNode<int>(2);
			var three = new TreeNode<int>(3);

			one.Left = two;
			one.Right = three;

			Assert.That(this.finder.Find(one, one, two), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, one, three), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, two, three), Is.EqualTo(one));
		}

		[Test]
		public void Find_TreeDepthThree_ReturnsCorrectAncestor()
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

			Assert.That(this.finder.Find(one, one, two), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, one, three), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, one, four), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, one, five), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, one, six), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, one, seven), Is.EqualTo(one));

			Assert.That(this.finder.Find(one, two, three), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, two, four), Is.EqualTo(two));
			Assert.That(this.finder.Find(one, two, five), Is.EqualTo(two));
			Assert.That(this.finder.Find(one, two, six), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, two, seven), Is.EqualTo(one));

			Assert.That(this.finder.Find(one, three, four), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, three, five), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, three, six), Is.EqualTo(three));
			Assert.That(this.finder.Find(one, three, seven), Is.EqualTo(three));

			Assert.That(this.finder.Find(one, four, five), Is.EqualTo(two));
			Assert.That(this.finder.Find(one, four, six), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, four, seven), Is.EqualTo(one));

			Assert.That(this.finder.Find(one, five, six), Is.EqualTo(one));
			Assert.That(this.finder.Find(one, five, seven), Is.EqualTo(one));

			Assert.That(this.finder.Find(one, six, seven), Is.EqualTo(three));
		}
	}
}
