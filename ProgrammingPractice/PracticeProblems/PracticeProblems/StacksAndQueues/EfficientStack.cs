using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	public class EfficientStack
	{
		private const int InitialSize = 10;

		private int[] internalStack;
		private LinkedList<int> minValStack;

		private int stackPtr;

		public EfficientStack()
		{
			this.internalStack = new int[InitialSize];
			this.minValStack = new LinkedList<int>();
			this.stackPtr = 0;
		}

		public void Push(int value)
		{
			if (this.stackPtr == this.internalStack.Length)
			{
				this.AllocateAdditionalSpace();	
			}

			int currMin = this.Min();
			if (value < currMin)
			{
				this.minValStack.AddFirst(value);
			}

			this.internalStack[this.stackPtr++] = value;
		}

		public int Pop()
		{
			if (this.stackPtr > 0)
			{
				int result = this.internalStack[--this.stackPtr];
				int currMin = this.Min();

				if (result == currMin)
				{
					this.minValStack.RemoveFirst();
				}

				return result;
			}

			return int.MaxValue;
		}

		public int Min()
		{
			if (this.stackPtr > 0)
			{
				return this.minValStack.First.Value;
			}

			return int.MaxValue;
		}

		private void AllocateAdditionalSpace()
		{
			Array.Resize(ref this.internalStack, this.internalStack.Length + InitialSize);
		}
	}
}
