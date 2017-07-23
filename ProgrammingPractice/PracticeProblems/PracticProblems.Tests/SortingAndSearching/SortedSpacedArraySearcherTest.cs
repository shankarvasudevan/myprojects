using System;
using NUnit.Framework;
using PracticeProblems.SortingAndSearching;

namespace PracticProblems.Tests.SortingAndSearching
{
    [TestFixture]
    public class SortedSpacedArraySearcherTest
    {
        private SortedSpacedArraySearcher searcher;

        [SetUp]
        public void Setup()
        {
            this.searcher = new SortedSpacedArraySearcher();
        }

        [Test]
        public void Find_NullInput_ReturnsNegativeOne()
        {
            Assert.That(this.searcher.Find(null, "word"), Is.EqualTo(-1));
        }

        [Test]
        public void Find_EmptyInput_ReturnsNegativeOne()
        {
            string[] input = { };
            Assert.That(this.searcher.Find(input, "hello"), Is.EqualTo(-1));
        }

        [Test]
        public void Find_ArrayWithSingleWordSameAsTarget_ReturnsIndexZero()
        {
            string[] input = { "hello" };
            Assert.That(this.searcher.Find(input, "hello"), Is.EqualTo(0));
        }

        [Test]
        public void Find_ArrayWithSingleWordDifferentToTarget_ReturnsNegativeOne()
        {
            string[] input = { "hello" };
            Assert.That(this.searcher.Find(input, "world"), Is.EqualTo(-1));
        }

        [Test]
        public void Find_ArrayWithMultipleWordsOneIsTarget_ReturnsCorrectIndex()
        {
            string[] input = { "hello", "world" };
            Assert.That(this.searcher.Find(input, "world"), Is.EqualTo(1));
        }

        [Test]
        public void Find_LargerArrayWithSpacesTargetExists_ReturnsCorrectIndex()
        {
            string[] input = { "apple", "", "", "board", "", "", "cat", "cop", "", "dog", "", "", "eskimo", "fred", "" };
            Assert.That(this.searcher.Find(input, "dog"), Is.EqualTo(9));
        }

        [Test]
        public void Find_LargerArrayWithSpacesTargetDoesExists_ReturnsNegativeOne()
        {
            string[] input = { "apple", "", "", "board", "", "", "cat", "cop", "", "dog", "", "", "eskimo", "fred", "" };
            Assert.That(this.searcher.Find(input, "catcop"), Is.EqualTo(-1));
        }

        [Test]
        public void Find_LargerArrayWithWordsOnlyInOneHalfTargetExists_ReturnsCorrectIndex()
        {
            string[] input = { "a", "b", "c", "d", "e", "", "", "", "", "", "", "", "" };
            Assert.That(this.searcher.Find(input, "d"), Is.EqualTo(3));
        }
    }
}
