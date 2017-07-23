using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class StacksBackedQueueTest
	{
		private const int DefaultSize = 3;

		[Test]
		public void EmptyQueue_DequeueReturnsZero()
		{
			var queue = new StacksBackedQueue(DefaultSize);
			Assert.That(queue.Dequeue(), Is.EqualTo(0));
		}

		[Test]
		public void SingleElementQueue_EnqueuesAndDequeuesCorrectly()
		{
			var queue = new StacksBackedQueue(DefaultSize);
			queue.Enqueue(10);
			Assert.That(queue.Dequeue(), Is.EqualTo(10));
		}

		[Test]
		public void MultipleElementQueue_EnqueuesAndDequeuesCorrectly()
		{
			var queue = new StacksBackedQueue(DefaultSize);
			queue.Enqueue(10);
			queue.Enqueue(11);
			queue.Enqueue(12);
			Assert.That(queue.Dequeue(), Is.EqualTo(10));
			Assert.That(queue.Dequeue(), Is.EqualTo(11));
			Assert.That(queue.Dequeue(), Is.EqualTo(12));
		}
	}
}
