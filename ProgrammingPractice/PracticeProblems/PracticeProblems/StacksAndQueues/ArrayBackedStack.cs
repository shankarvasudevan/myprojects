using System;
namespace PracticeProblems
{
	public enum StackOption
	{
		First,
		Second,
		Third
	};

	public class ArrayBackedStack
	{
		private readonly int incrementalSize;
		private int[] internalStack;

		private int secondStackPointer; 
		private int thirdStackPointer;

		private int firstStackCounter;
		private int secondStackCounter;
		private int thirdStackCounter;

		public ArrayBackedStack(int initialSize)
		{
			this.incrementalSize = initialSize / 2;

			this.secondStackPointer = initialSize / 3;
			this.thirdStackPointer = 2 * initialSize / 3;

			this.firstStackCounter = 0;
			this.secondStackCounter = 0;
			this.thirdStackCounter = 0;

			this.internalStack = new int[initialSize];
		}

		public void Push(StackOption stack, int value)
		{
			switch (stack)
			{
				case StackOption.First:
					PushFirstStack(value);
					break;
				case StackOption.Second:
					PushSecondStack(value);
					break;
				default:
					PushThirdStack(value);
					break;
			}
		}

		public int Pop(StackOption stack)
		{
			switch (stack)
			{
				case StackOption.First:
					return PopFirstStack();
				case StackOption.Second:
					return PopSecondStack();
				default:
					return PopThirdStack();
			}
		}

		private int PopFirstStack()
		{
			if (this.firstStackCounter > 0)
			{
				this.firstStackCounter--;
				return this.internalStack[this.firstStackCounter];
			}

			return 0;
		}

		private int PopSecondStack()
		{
			if (this.secondStackCounter > 0)
			{
				this.secondStackCounter--;
				return this.internalStack[this.secondStackPointer + this.secondStackCounter];
			}

			return 0;
		}

		private int PopThirdStack()
		{
			if (this.thirdStackCounter > 0)
			{
				this.thirdStackCounter--;
				return this.internalStack[this.thirdStackPointer + this.thirdStackCounter];
			}

			return 0;
		}

		private void PushFirstStack(int value)
		{
			if (this.FirstStackFull())
			{
				int lastElemInSecondStack = this.ShiftSecondStack();
				this.PushSecondStack(lastElemInSecondStack);
			}

			this.internalStack[this.firstStackCounter] = value;
			this.firstStackCounter++;
		}

		private void PushSecondStack(int value)
		{
			if (this.SecondStackFull())
			{
				int lastElemInThirdStack = this.ShiftThirdStack();
				this.PushThirdStack(lastElemInThirdStack);
			}

			this.internalStack[this.secondStackPointer + this.secondStackCounter] = value;
			this.secondStackCounter++;
		}

		private void PushThirdStack(int value)
		{
			if (this.ThirdStackFull())
			{
				this.AllocateAdditionalSpace();
			}

			this.internalStack[this.thirdStackPointer + this.thirdStackCounter] = value;
			this.thirdStackCounter++;
		}

		private bool FirstStackFull()
		{
			return this.firstStackCounter >= this.secondStackPointer;
		}

		private bool SecondStackFull()
		{
			return this.secondStackPointer + this.secondStackCounter >= this.thirdStackPointer;
		}

		private bool ThirdStackFull()
		{
			return this.thirdStackPointer + this.thirdStackCounter >= this.internalStack.Length;
		}

		private int ShiftSecondStack()
		{
			int result = this.ShiftStack(this.secondStackPointer, this.secondStackCounter);
			this.secondStackPointer++;
			this.secondStackCounter--;

			return result;
		}

		private int ShiftThirdStack()
		{
			int result = this.ShiftStack(this.thirdStackPointer, this.thirdStackCounter);
			this.thirdStackPointer++;
			this.thirdStackCounter--;

			return result;
		}

		private int ShiftStack(int startIndex, int count)
		{
			int prev = this.internalStack[startIndex];
			int curr = 0;
			this.internalStack[startIndex] = 0;

			for (int i = 1; i < count; i++)
			{
				curr = this.internalStack[startIndex+i];
				this.internalStack[startIndex+i] = prev;
				prev = curr;
			}

			return prev;
		}

		private void AllocateAdditionalSpace()
		{
			Array.Resize(ref this.internalStack, this.internalStack.Length + this.incrementalSize);
		}
	}
}
