using System;
namespace PracticeProblems
{
	public static class StringReverser
	{
		public static char [] Reverse (char [] original)
		{
			int len = original.Length;
			char [] reversed = new char [original.Length];

			// 'a','b','c','d','\0'
			for (int i = 0; i < len; i++) {
				reversed [i] = original [len - i - 1];
			}

			return reversed;
		}
	}
}
