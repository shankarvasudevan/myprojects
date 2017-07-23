using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class EfficientStackTest
	{
		[Test]
		public void EmptyStack_PopAndMinReturnIntegerMinValue()
		{
			var stack = new EfficientStack();
			Assert.That(stack.Min(), Is.EqualTo(int.MaxValue));
			Assert.That(stack.Pop(), Is.EqualTo(int.MaxValue));
		}

		[Test]
		public void PushOneAndPopOne_ShouldReturnCorrectMinAndPopCorrectElement()
		{
			var stack = new EfficientStack();
			stack.Push(1);
			Assert.That(stack.Min(), Is.EqualTo(1));
			Assert.That(stack.Pop(), Is.EqualTo(1));
		}

		[Test]
		public void PushFourAndPopFour_ReturnsCorrectMinAndPopsInCorrectOrder()
		{
			var stack = new EfficientStack();

			stack.Push(5); 
			stack.Push(7); 
			stack.Push(3); 
			stack.Push(4); 

			Assert.That(stack.Min(), Is.EqualTo(3));
			Assert.That(stack.Pop(), Is.EqualTo(4));

			Assert.That(stack.Min(), Is.EqualTo(3));
			Assert.That(stack.Pop(), Is.EqualTo(3));

			Assert.That(stack.Min(), Is.EqualTo(5));
			Assert.That(stack.Pop(), Is.EqualTo(7));

			Assert.That(stack.Min(), Is.EqualTo(5));
			Assert.That(stack.Pop(), Is.EqualTo(5));
		}
	}
}
