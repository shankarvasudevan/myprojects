using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems.SortingAndSearching;

namespace PracticProblems.Tests.SortingAndSearching
{
    [TestFixture]
    public class AnagramSorterTest
    {
        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new string[] { "abc" },
                    new string[] { "abc" })
                        .SetName("OneString_ArrayUnchanged");

                yield return new TestCaseData(
                    new string[] { "abc", "xyz" },
                    new string[] { "abc", "xyz" })
                        .SetName("NoAnagrams_ArrayUnchanged");

                yield return new TestCaseData(
                    new string[] { "abc", "xyz", "cba" },
                    new string[] { "abc", "cba", "xyz" })
                        .SetName("OnePairOfAnagrams_ShouldPutTogether");

                yield return new TestCaseData(
                    new string[] { "abc", "xyz", "cba", "hello", "world", "loleh" },
                    new string[] { "abc", "cba", "xyz", "hello", "loleh", "world" })
                        .SetName("TwoPairsOfAnagrams_ShouldGroupTogether");

                yield return new TestCaseData(
                    new string[] { "abc", "xyz", "cba", "bca", "acb", "bac" },
                    new string[] { "abc", "cba", "bca", "acb", "bac", "xyz" })
                        .SetName("SixWordsFiveAnagrams_ShouldGroupAllFiveTogether");
            }
        }

		[Test, TestCaseSource("TestCases")]
		public void SortTests(string[] input, string[] expected)
		{
            string[] actual = new AnagramSorter().SortAnagrams(input);
            Assert.That(
                actual, 
                Is.EqualTo(expected), 
                string.Format("Expected: {0}, Actual:s {1}", Print(expected), Print(actual)));
		}

        private static string Print(string[] arr)
        {
            string str = "[";
            foreach (var s in arr)
            {
                str += s + ",";
            }

            str += "]";

            return str;
        }
    }
}
