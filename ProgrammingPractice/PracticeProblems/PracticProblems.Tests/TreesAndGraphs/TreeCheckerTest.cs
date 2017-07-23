using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class TreeCheckerTest
	{
		private TreeChecker balanceChecker;

		[SetUp]
		public void Setup()
		{
			this.balanceChecker = new TreeChecker();
		}

		[Test]
		public void IsBalanced_EmptyTree_ReturnsTrue()
		{
			Assert.That(this.balanceChecker.IsBalanced<string>(null), Is.EqualTo(true));
		}

		[Test]
		public void IsBalanced_RootOnly_ReturnsTrue()
		{
			TreeNode<string> root = new TreeNode<string>("root");
			Assert.That(this.balanceChecker.IsBalanced(root), Is.EqualTo(true));
		}

		[Test]
		public void IsBalanced_LeftSubtreeDepth2NoRightSubtree_ReturnsFalse()
		{
			TreeNode<string> a = new TreeNode<string>("a");
			TreeNode<string> b = new TreeNode<string>("b");
			TreeNode<string> c = new TreeNode<string>("c");

			a.Left = b;
			b.Left = c;

			Assert.That(this.balanceChecker.IsBalanced(a), Is.EqualTo(false));
		}

		[Test]
		public void IsBalanced_LeftAndRightSubtreeDepth2_ReturnsTrue()
		{
			TreeNode<string> a = new TreeNode<string>("a");
			TreeNode<string> b = new TreeNode<string>("b");
			TreeNode<string> c = new TreeNode<string>("c");
			TreeNode<string> d = new TreeNode<string>("d");
			TreeNode<string> e = new TreeNode<string>("e");
			TreeNode<string> f = new TreeNode<string>("f");
			TreeNode<string> g = new TreeNode<string>("g");

			a.Left = b;
			a.Right = c;

			b.Left = d;
			b.Right = e;

			c.Left = f;
			c.Right = g;

			Assert.That(this.balanceChecker.IsBalanced(a), Is.EqualTo(true));
		}

		[Test]
		public void IsBalance_LeftSubtreeDepth3RightSubtreeMinDepth1_ReturnsFalse()
		{
			TreeNode<string> a = new TreeNode<string>("a");
			TreeNode<string> b = new TreeNode<string>("b");
			TreeNode<string> c = new TreeNode<string>("c");
			TreeNode<string> d = new TreeNode<string>("d");
			TreeNode<string> e = new TreeNode<string>("e");
			TreeNode<string> f = new TreeNode<string>("f");
			TreeNode<string> g = new TreeNode<string>("g");

			a.Left = b;
			a.Right = c;

			b.Left = d;
			b.Right = e;

			e.Left = f;

			c.Right = g;

			Assert.That(this.balanceChecker.IsBalanced(a), Is.EqualTo(false));
		}
	}
}
