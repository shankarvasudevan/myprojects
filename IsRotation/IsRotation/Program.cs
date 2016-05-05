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
			int len = s1.Length;

			if (s2.Length != len)
			{
				return false;
			}

			for (int i=1; i <= len; i++)
			{
				string front = s2.Substring(0,i);
				string back = s2.Substring(i,len-i);

				if (IsSubstring(s1, front) && IsSubstring(s1, back))
				{
					return true;
				}

			}

			return false;
		}

		static bool IsSubstring(string word, string potentialSubstring)
		{
			return word.Contains(potentialSubstring);
		}
	}
}
