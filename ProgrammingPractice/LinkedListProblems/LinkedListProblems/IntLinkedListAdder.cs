using System;

namespace LinkedListProblems
{
	public class IntLinkedListAdder
	{
		public IntNode Add(IntNode n1, IntNode n2)
		{
			IntNode resIter = null;
			IntNode resHead = null;
			int carry = 0;

			IntNode tmp1 = n1;
			IntNode tmp2 = n2;

			while (tmp1 != null || tmp2 != null || carry != 0)
			{
				int tmp1Val = tmp1 != null ? tmp1.Data : 0;
				int tmp2Val = tmp2 != null ? tmp2.Data : 0;

				int resVal = tmp1Val + tmp2Val + carry;
				carry = resVal / 10;

				IntNode resNode = new IntNode
				{
					Data = (resVal % 10),
					Next = null
				};

				if (resIter == null) 
				{
					resIter = resNode;
					resHead = resIter;
				} 
				else 
				{
					resIter.Next = resNode;
					resIter = (IntNode)resIter.Next;
				}

				if (tmp1 != null) 
				{
					tmp1 = (IntNode)tmp1.Next;
				}

				if (tmp2 != null) 
				{
					tmp2 = (IntNode)tmp2.Next;
				}
			}
				
			return resHead;
		}
	}
}

