using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public class SetOfStacks
	{
		private int stackSize;
		private LinkedList<Stack> setOfStacks;

		public SetOfStacks(int stackSize)
		{
			this.stackSize = stackSize;
			this.setOfStacks = new LinkedList<Stack>();
			this.setOfStacks.AddFirst(new Stack(stackSize));
		}

		public void Push(int value)
		{
			var latestStack = this.setOfStacks.First.Value;
			if (latestStack.IsFull())
			{
				this.setOfStacks.AddFirst(new Stack(this.stackSize));
				latestStack = this.setOfStacks.First.Value;
			}

			latestStack.Push(value);
		}

		public int Pop()
		{
			var latestStack = this.setOfStacks.First.Value;
			if (latestStack.IsEmpty())
			{
				this.setOfStacks.RemoveFirst();
				var latestStackNode = this.setOfStacks.First;
				if (latestStackNode == null)
				{
					return 0;
				}

				latestStack = latestStackNode.Value;
			}

			return latestStack.Pop();
		}
	}
}
