using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class ArrayBackedStackTest
	{
		[Test]
		public void StackSize6_Push1OnEachStackAndPopEach_ShouldUseCorrectStack()
		{
			var stack = new ArrayBackedStack(6);
			stack.Push(StackOption.First, 1);
			stack.Push(StackOption.Second, 2);
			stack.Push(StackOption.Third, 3);
			Assert.That(stack.Pop(StackOption.First), Is.EqualTo(1));
			Assert.That(stack.Pop(StackOption.Second), Is.EqualTo(2));
			Assert.That(stack.Pop(StackOption.Third), Is.EqualTo(3));
		}

		[Test]
		public void StackSize6_Push2OnEachStackOnPopEach_ShouldPopInReverseOrder()
		{
			var stack = new ArrayBackedStack(6);
			stack.Push(StackOption.First, 1);
			stack.Push(StackOption.First, 2);
			stack.Push(StackOption.Second, 3);
			stack.Push(StackOption.Second, 4);
			stack.Push(StackOption.Third, 5);
			stack.Push(StackOption.Third, 6);
			Assert.That(stack.Pop(StackOption.First), Is.EqualTo(2));
			Assert.That(stack.Pop(StackOption.First), Is.EqualTo(1));
			Assert.That(stack.Pop(StackOption.Second), Is.EqualTo(4));
			Assert.That(stack.Pop(StackOption.Second), Is.EqualTo(3));
			Assert.That(stack.Pop(StackOption.Third), Is.EqualTo(6));
			Assert.That(stack.Pop(StackOption.Third), Is.EqualTo(5));
		}

		[Test]
		public void StackSize6_Push2OnEachStackAndThenPush1OnEachStack_ShouldResizeButStillPopInReverseOrder()
		{
			var stack = new ArrayBackedStack(6);
			stack.Push(StackOption.First, 1);
			stack.Push(StackOption.First, 2);
			stack.Push(StackOption.Second, 3);
			stack.Push(StackOption.Second, 4);
			stack.Push(StackOption.Third, 5);
			stack.Push(StackOption.Third, 6);
			stack.Push(StackOption.First, 7);
			stack.Push(StackOption.Second, 8);
			stack.Push(StackOption.Third, 9);
			Assert.That(stack.Pop(StackOption.First), Is.EqualTo(7));
			Assert.That(stack.Pop(StackOption.First), Is.EqualTo(2));
			Assert.That(stack.Pop(StackOption.First), Is.EqualTo(1));
			Assert.That(stack.Pop(StackOption.Second), Is.EqualTo(8));
			Assert.That(stack.Pop(StackOption.Second), Is.EqualTo(4));
			Assert.That(stack.Pop(StackOption.Second), Is.EqualTo(3));
			Assert.That(stack.Pop(StackOption.Third), Is.EqualTo(9));
			Assert.That(stack.Pop(StackOption.Third), Is.EqualTo(6));
			Assert.That(stack.Pop(StackOption.Third), Is.EqualTo(5));
		}
	}
}
