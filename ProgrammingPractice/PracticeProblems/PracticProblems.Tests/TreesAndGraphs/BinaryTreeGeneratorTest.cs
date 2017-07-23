using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class BinaryTreeGeneratorTest
	{
		private BinaryTreeGenerator generator;

		[SetUp]
		public void Setup()
		{
			this.generator = new BinaryTreeGenerator();
		}

		[Test]
		public void Generate_EmptyArray_ReturnsNull()
		{
			Assert.That(this.generator.Generate(null), Is.Null);
		}

		[Test]
		public void Generate_SingleElement_MaxDepthShouldBeOne()
		{
			var input = new int[] { 1 };
			var generatedTree = this.generator.Generate(input);

			var depth = new TreeChecker().MaxDepth(generatedTree);

			Assert.That(depth, Is.EqualTo(1));
		}

		[Test]
		public void Generate_ThreeElements_MaxDepthShouldBeTwo()
		{
			var input = new int[] { 1, 2, 3 };
			var generatedTree = this.generator.Generate(input);

			var depth = new TreeChecker().MaxDepth(generatedTree);

			Assert.That(depth, Is.EqualTo(2));
		}

		[Test]
		public void Generate_FourElements_MaxDepthShouldBeThree()
		{
			var input = new int[] { 1, 2, 3, 4 };
			var generatedTree = this.generator.Generate(input);

			var depth = new TreeChecker().MaxDepth(generatedTree);

			Assert.That(depth, Is.EqualTo(3));
		}

		[Test]
		public void Generate_SevenElements_MaxDepthShouldBeThree()
		{
			var input = new int[] { 1, 2, 3, 4, 5, 6, 7 };
			var generatedTree = this.generator.Generate(input);

			var depth = new TreeChecker().MaxDepth(generatedTree);

			Assert.That(depth, Is.EqualTo(3));
		}

		[Test]
		public void Generate_EightElements_MaxDepthShouldBeFour()
		{
			var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			var generatedTree = this.generator.Generate(input);

			var depth = new TreeChecker().MaxDepth(generatedTree);

			Assert.That(depth, Is.EqualTo(4));
		}
	}
}
