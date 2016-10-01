using System;

namespace IsRotation
{
	class MainClass
	{
		static void Main(string[] args)
		{
			string s1 = "anderson";
			string s2 = "sonander";

			Console.WriteLine(IsRotation(s1,s2));
		}

		static bool IsRotation(string s1, string s2)
		{
			if (s2.Length != s1.Length)
			{
				return false;
			}

			string s1_concatenated = s1 + s1;

			return IsSubstring (s1_concatenated, s2);
		}

		static bool IsSubstring(string word, string potentialSubstring)
		{
			return word.Contains(potentialSubstring);
		}
	}
}
