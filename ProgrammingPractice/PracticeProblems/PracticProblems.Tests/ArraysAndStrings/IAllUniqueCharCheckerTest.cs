using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class IAllUniqueCharCheckerTest
	{
		[Test]
		[TestCase(null, true, Description="Null_ReturnsTrue")]
		[TestCase("", true, Description = "EmptyString_ReturnsTrue")]
		[TestCase("a", true, Description = "SingleCharacter_ReturnsTrue")]
		[TestCase("aa", false, Description = "RepeatedSingleCharacter_ReturnsFalse")]
		[TestCase("ab", true, Description = "DifferentCharacters_ReturnsTrue")]
		[TestCase("abcdefghijklmnopqarst", false, Description = "LongerStringWithRepeatedChar_ReturnsFalse")]
		[TestCase("abcdefghijklmnopqrst", true, Description = "LongerStringWithoutRepeatedChar_ReturnsTrue")]
		public void HasUniqueCharsTestCases(string word, bool expectedResult)
		{
			IAllUniqueCharChecker uniqueCharChecker = new AllUniqueCharCheckerWithoutDataStructures();
			var actualResult = uniqueCharChecker.HasUniqueChars(word);
			Assert.That (actualResult, Is.EqualTo (expectedResult));
		}
	}
}
