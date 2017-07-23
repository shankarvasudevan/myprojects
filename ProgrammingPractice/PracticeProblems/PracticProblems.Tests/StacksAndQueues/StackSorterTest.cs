using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class StackSorterTest
	{
		private const int DefaultStackSize = 5;

		[Test]
		public void Sort_EmptyStack_RemainsEmpty()
		{
			var stack = new Stack(DefaultStackSize);
			var sorter = new StackSorter(DefaultStackSize);
			stack = sorter.Sort(stack);
			Assert.IsTrue(stack.IsEmpty());
		}

		[Test]
		public void Sort_SortedStack_RemainsTheSame()
		{
			var stack = new Stack(DefaultStackSize);
			var sorter = new StackSorter(DefaultStackSize);
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			stack = sorter.Sort(stack);
			Assert.That(stack.Pop(), Is.EqualTo(3));
			Assert.That(stack.Pop(), Is.EqualTo(2));
			Assert.That(stack.Pop(), Is.EqualTo(1));
		}

		[Test]
		public void Sort_UnsortedStack_SortsCorrectly()
		{
			var stack = new Stack(DefaultStackSize);
			var sorter = new StackSorter(DefaultStackSize);
			stack.Push(2);
			stack.Push(4);
			stack.Push(1);
			stack.Push(3);

			stack = sorter.Sort(stack);
			Assert.That(stack.Pop(), Is.EqualTo(4));
			Assert.That(stack.Pop(), Is.EqualTo(3));
			Assert.That(stack.Pop(), Is.EqualTo(2));
			Assert.That(stack.Pop(), Is.EqualTo(1));
		}
	}
}
