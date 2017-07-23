using System;
namespace PracticeProblems
{
	public class Stack
	{
		private int[] internalStack;
		private int stackPtr;

		public Stack(int size)
		{
			this.internalStack = new int[size];
			this.stackPtr = 0;
		}

		public void Push(int value)
		{
			if (!this.IsFull())
			{
				this.internalStack[this.stackPtr++] = value;
			}
		}

		public int Pop()
		{
			int result = this.internalStack[this.stackPtr - 1];
			this.internalStack[this.stackPtr - 1] = 0;
			this.stackPtr--;

			return result;
		}

		public bool IsFull()
		{
			return this.stackPtr == this.internalStack.Length;
		}

		public int Peek()
		{
			if (this.stackPtr == 0)
			{
				return 0;
			}

			return this.internalStack[this.stackPtr-1];
		}

		public bool IsEmpty()
		{
			return this.stackPtr == 0;
		}
	}
}
