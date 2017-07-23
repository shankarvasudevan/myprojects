using System;
namespace PracticeProblems
{
	public class StackSorter
	{
		private readonly int maxSize;

		public StackSorter(int maxSize)
		{
			this.maxSize = maxSize;
		}

		public Stack Sort(Stack stack)
		{
			if (stack.IsEmpty())
			{
				return stack;
			}

			Stack sortedStack = new Stack(this.maxSize);
			int last = stack.Pop();
			sortedStack.Push(last);

			while (!stack.IsEmpty())
			{
				int curr = stack.Peek();
				if (curr >= sortedStack.Peek())
				{
					sortedStack.Push(stack.Pop());
				}
				else
				{
					Stack tmpStack = new Stack(this.maxSize);
					while (curr < sortedStack.Peek())
					{
						tmpStack.Push(sortedStack.Pop());
					}

					sortedStack.Push(stack.Pop());
					while (!tmpStack.IsEmpty())
					{
						sortedStack.Push(tmpStack.Pop());
					}
				}
			}

			return sortedStack;
		}
	}
}
