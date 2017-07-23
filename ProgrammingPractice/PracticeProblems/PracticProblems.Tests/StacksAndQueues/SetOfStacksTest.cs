using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class SetOfStacksTest
	{
		[Test]
		public void CapacityOne_PushesOnceAndPopsTwice_SecondPopShouldReturnDefaultValue()
		{
			var setOfStacks = new SetOfStacks(1);
			setOfStacks.Push(1);
			Assert.That(setOfStacks.Pop(), Is.EqualTo(1));
			Assert.That(setOfStacks.Pop(), Is.EqualTo(0));
		}

		[Test]
		public void CapacityThree_DoesNotExceedCapacity_PushesAndPopsCorrectly()
		{
			var setOfStacks = new SetOfStacks(3);
			setOfStacks.Push(1);
			setOfStacks.Push(2);
			setOfStacks.Push(3);
			Assert.That(setOfStacks.Pop(), Is.EqualTo(3));
			Assert.That(setOfStacks.Pop(), Is.EqualTo(2));
			Assert.That(setOfStacks.Pop(), Is.EqualTo(1));
		}

		[Test]
		public void CapacityTwo_ExceedsCapacityByTwo_PushesAndPopsCorrectly()
		{
			var setOfStacks = new SetOfStacks(2);
			setOfStacks.Push(1);
			setOfStacks.Push(2);
			setOfStacks.Push(3);
			setOfStacks.Push(4);
			Assert.That(setOfStacks.Pop(), Is.EqualTo(4));
			Assert.That(setOfStacks.Pop(), Is.EqualTo(3));
			Assert.That(setOfStacks.Pop(), Is.EqualTo(2));
			Assert.That(setOfStacks.Pop(), Is.EqualTo(1));
		}
	}
}
