using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems
{
	public static class SpaceReplacer
	{
		public static string Replace (string input)
		{
			if (input == null) 
			{
				return null;
			}

			string output = string.Empty;
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == ' ') {
					output += '%';
					output += '2';
					output += '0';
				} else {
					output += input [i];
				}
			}

			return output;
		}
	}
}
