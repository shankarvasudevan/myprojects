using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class BstToLinkedListConverterTest
	{
		private BstToLinkedListConverter converter;

		[SetUp]
		public void Setup()
		{
			this.converter = new BstToLinkedListConverter();
		}

		[Test]
		public void Convert_EmptyTree_ReturnsEmptyList()
		{
			Assert.That(this.converter.Convert(null), Is.Empty);
		}

		[Test]
		public void Convert_DepthOne_ReturnsOneList()
		{
			var root = new TreeNode<int>(1);
			var generatedList = this.converter.Convert(root);

			Assert.That(generatedList.Count, Is.EqualTo(1));
			var single = generatedList.Single();

			Assert.That(single.First.Value, Is.EqualTo(root));
		}

		[Test]
		public void Convert_DepthTwo_ReturnsTwoLists()
		{
			var one = new TreeNode<int>(1);
			var two = new TreeNode<int>(2);
			var three = new TreeNode<int>(3);

			two.Left = one;
			two.Right = three;

			var generatedList = this.converter.Convert(two);

			Assert.That(generatedList.Count, Is.EqualTo(2));

			var firstList = generatedList[0];

			Assert.That(firstList.First.Value, Is.EqualTo(two));

			var secondList = generatedList[1];

			Assert.That(secondList.First.Value, Is.EqualTo(one));
			Assert.That(secondList.First.Next.Value, Is.EqualTo(three));
		}


		[Test]
		public void Convert_DepthThree_ReturnsThreeLists()
		{
			var four = new TreeNode<int>(4);
			var two = new TreeNode<int>(2);
			var six = new TreeNode<int>(6);
			var one = new TreeNode<int>(1);
			var three = new TreeNode<int>(3);
			var five = new TreeNode<int>(5);
			var seven = new TreeNode<int>(7);

			four.Left = two;
			four.Right = six;
			two.Left = one;
			two.Right = three;
			six.Left = five;
			six.Right = seven;

			var generatedList = this.converter.Convert(four);

			Assert.That(generatedList.Count, Is.EqualTo(3));

			var firstList = generatedList[0];

			Assert.That(firstList.First.Value, Is.EqualTo(four));

			var secondList = generatedList[1];

			Assert.That(secondList.First.Value, Is.EqualTo(two));
			Assert.That(secondList.First.Next.Value, Is.EqualTo(six));

			var thirdList = generatedList[2];

			Assert.That(thirdList.First.Value, Is.EqualTo(one));
			Assert.That(thirdList.First.Next.Value, Is.EqualTo(three));
			Assert.That(thirdList.First.Next.Next.Value, Is.EqualTo(five));
			Assert.That(thirdList.First.Next.Next.Next.Value, Is.EqualTo(seven));
		}
	}
}
