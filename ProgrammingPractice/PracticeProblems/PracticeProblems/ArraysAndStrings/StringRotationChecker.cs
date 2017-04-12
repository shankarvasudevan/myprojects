using System;
namespace PracticeProblems
{
	public static class StringRotationChecker
	{
		public static bool IsRotation (string word1, string word2)
		{
			if (word1 == null || word2 == null) 
			{
				return false;
			}

			if (word1.Length == 0 || word2.Length == 0) 
			{
				return false;
			}

			/*
			 * Algorithm:
			 * 1) Get the first letter of the first word
			 * 2) Iterate through the second word until you hit that letter
			 * 3) Split the word into two substrings before and after that letter
			 * 4) Check if both substrings are substrings of the first word, If Yes then return True
			 * 5) Repeat for every occurrence of the first lette of the first word in the second word
			 * 6) If no more occurrences of that letter, return False
			 */

			char [] firstWord = word1.ToCharArray ();
			char [] secondWord = word2.ToCharArray ();

			char firstLetter = firstWord [0];

			string substringA = string.Empty;
			string substringB = string.Empty;

			int i = 0;
			while (i < secondWord.Length && secondWord[i] != firstLetter) 
			{
				substringA += secondWord [i];
				i++;
			}

			if (i == secondWord.Length) 
			{
				return false;
			}

			for (int j = i; j < secondWord.Length; j++) 
			{
				substringB += secondWord [j];
			}

			if (secondWord.IsSubstring(

			return false;
		}
	}
}
