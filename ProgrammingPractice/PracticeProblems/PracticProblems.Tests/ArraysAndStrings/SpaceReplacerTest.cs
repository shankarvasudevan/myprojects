using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class SpaceReplacerTest
	{
		[Test]
		[TestCase (null, null)]
		[TestCase ("", "")]
		[TestCase (" ", "%20")]
		[TestCase ("  ", "%20%20")]
		[TestCase ("hello world", "hello%20world")]
		public void ReplaceTests(string input, string expectedOutput)
		{
			Assert.That(SpaceReplacer.Replace(input), Is.EqualTo(expectedOutput));
		}
	}
}
