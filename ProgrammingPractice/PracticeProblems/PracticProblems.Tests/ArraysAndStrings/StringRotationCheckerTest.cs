using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class StringRotationCheckerTest
	{
		[Test]
		[TestCase(null, null, false, Description = "NullWords_ReturnsFalse")]
		[TestCase(null, "", false, Description = "NullAndEmpty_ReturnFalse")]
		[TestCase("", "", true, Description = "EmptyAndEmpty_ReturnTrue")]
		[TestCase("a", "a", true, Description = "EqualStrings_ReturnTrue")]
		[TestCase("a", "b", false, Description = "DifferentStrings_ReturnFalse")]
		[TestCase("a", "ab", false, Description = "Substring_ReturnFalse")]
		[TestCase("ba", "ab", true, Description = "Anagrams_ReturnTrue")]
		[TestCase("terbottlewa", "waterbottle", true, Description = "LongerAnagram_ReturnTrue")]
		public void IsRotationTests (string word1, string word2, bool expectedResult)
		{
			bool actualResult = StringRotationChecker.IsRotation (word1, word2);
			Assert.That (actualResult, Is.EqualTo (expectedResult));
		}
	}
}
