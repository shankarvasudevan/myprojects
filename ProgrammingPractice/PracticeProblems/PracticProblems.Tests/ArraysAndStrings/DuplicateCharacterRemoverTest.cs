using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class DuplicateCharacterRemoverTest
	{
		public static IEnumerable<TestCaseData> TestCases 
		{
			get 
			{
				yield return new TestCaseData (string.Empty)
					.Returns (string.Empty)
					.SetName ("EmptyString_ReturnsEmpty");

				yield return new TestCaseData (null)
					.Returns (null)
					.SetName ("NullString_ReturnsNull");

				yield return new TestCaseData ("a")
					.Returns ("a")
					.SetName ("SingleCharacter_ReturnsOriginal");

				yield return new TestCaseData ("aa")
					.Returns ("a")
					.SetName ("RepeatedCharacter_RemovesOneCharacter");

				yield return new TestCaseData ("aA")
					.Returns ("aA")
					.SetName ("SameLetterDifferentCharacters_ReturnsOriginal");

				yield return new TestCaseData ("helloworld")
					.Returns ("helowrd")
					.SetName ("MultipleLettersAndCharacters_RemovesDuplicateLetters");
			}
		}

		[Test, TestCaseSource("TestCases")]
		public string RemoveDuplicatesTestCases (string input)
		{
			return DuplicateCharacterRemover.RemoveDuplicates (input);
		}
	}
}

