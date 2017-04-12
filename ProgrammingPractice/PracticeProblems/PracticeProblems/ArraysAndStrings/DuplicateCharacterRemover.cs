using System;
namespace PracticeProblems
{
	public static class DuplicateCharacterRemover
	{
		public static string RemoveDuplicates(string original)
		{
			if (string.IsNullOrEmpty (original)) 
			{
				return original;
			}
			
			string withoutDuplicates = original;
			char[] characters = original.ToCharArray();
			bool [] hit = new bool [256];
			int indexOffset = 0;
			for (int i = 0; i < characters.Length; i++) 
			{
				int asciiVal = (int)characters [i];
				if (hit [asciiVal]) 
				{
					withoutDuplicates = withoutDuplicates.Remove (i-indexOffset, 1);
					indexOffset++;
				}

				hit [asciiVal] = true;
			}

			return withoutDuplicates;
		}
	}
	
}