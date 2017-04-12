using System;
namespace PracticeProblems
{
	public class AllUniqueCharCheckerWithoutDataStructures : IAllUniqueCharChecker
	{
		public bool HasUniqueChars (string word)
		{
			if (string.IsNullOrEmpty (word)) 
			{
				return true;
			}

			int checker = 0;
			char[] wordArr = word.ToCharArray();
			for (int i = 0; i < wordArr.Length; i++) 
			{
				int val = wordArr[i];
				if ((checker & (1 << val)) > 0) 
				{
					return false;
				}

				checker |= (1 << val);
			}

			return true;
		}

	}
}
