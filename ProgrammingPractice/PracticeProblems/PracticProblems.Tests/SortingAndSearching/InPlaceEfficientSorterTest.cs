using System;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProblems.SortingAndSearching;

namespace PracticProblems.Tests.SortingAndSearching
{
    [TestFixture]
    public class InPlaceEfficientSorterTest
    {
        private InPlaceEfficientSorter sorter;

        [SetUp]
        public void Setup()
        {
            this.sorter = new InPlaceEfficientSorter();
        }

        [Test]
        public void Sort_EmptyInput_ReturnsEmptyOutput()
        {
            Assert.That(this.sorter.Sort(new string[] { }), Is.Empty);
        }

        [Test]
        public void Sort_SingleInput_ReturnsSingleOutput()
        {
            string[] input = { "hello" };
            Assert.That(this.sorter.Sort(input), Is.EquivalentTo(input));
        }

        [Test]
        public void Sort_SortedInput_ReturnsSortedOutput()
        {
            string[] input = { "hello", "how are you?", "i am good" };
            Assert.That(this.sorter.Sort(input), Is.EquivalentTo(input));
        }

        [Test]
        public void Sort_UnsortedInput_ReturnsSortedOutput()
        {
            string[] input = { "hello", "my name is Shankar", "i am good", "how are you" };
            string[] expectedOutput = { "hello", "how are you", "i am good", "my name is Shankar" };

            Assert.That(this.sorter.Sort(input), Is.EquivalentTo(expectedOutput));
        }
    }
}
