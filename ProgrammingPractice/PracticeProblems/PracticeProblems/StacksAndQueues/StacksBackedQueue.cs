using System;
namespace PracticeProblems
{
	public class StacksBackedQueue
	{
		private Stack stackA;
		private Stack stackB;

		public StacksBackedQueue(int size)
		{
			this.stackA = new Stack(size);
			this.stackB = new Stack(size);
		}

		public void Enqueue(int value)
		{
			this.stackA.Push(value);
		}

		public int Dequeue()
		{
			if (this.stackA.IsEmpty())
			{
				return 0;
			}

			while (!this.stackA.IsEmpty())
			{
				this.stackB.Push(this.stackA.Pop());
			}

			int result = this.stackB.Pop();

			while (!this.stackB.IsEmpty())
			{
				this.stackA.Push(this.stackB.Pop());
			}

			return result;
		}
	}
}
