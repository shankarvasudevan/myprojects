using System;
namespace PracticeProblems
{
	public class AllUniqueCharChecker : IAllUniqueCharChecker
	{
		public bool HasUniqueChars(string word)
		{
			if (string.IsNullOrEmpty(word)) 
			{
				return true;
			}

			bool[] characters = new bool[65536];
			foreach (char c in word) 
			{
				if (characters [(int)c] == true) 
				{
					return false;
				}

				characters [(int)c] = true;

			}

			return true;
		}
	}


}
