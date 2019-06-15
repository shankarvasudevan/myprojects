using System;
using System.Collections.Generic;
using NUnit.Framework;
using Solvers;

namespace SolverTests
{
    [TestFixture]
    public class DiamondPrinterTests
    {
        public IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(0)
                    .Returns(string.Empty)
                    .SetName("EmptyDiamond");

                yield return new TestCaseData(1)
                    .Returns("1")
                    .SetName("SingleDiamond");

                yield return new TestCaseData(2)
                    .Returns(" 1 " +
                             "121" +
                             " 1 ")
                    .SetName("DiamondOfTwo");

                yield return new TestCaseData(-1)
                    .Returns(string.Empty)
                    .SetName("NegativeDiamond");

                yield return new TestCaseData(5)
                    .Returns("    1    " +
                             "   121   " +
                             "  12321  " +
                             " 1234321 " +
                             "123454321" +
                             " 1234321 " +
                             "  12321  " +
                             "   121   " +
                             "    1    ")
                    .SetName("DiamondOfFive");
            }
        }

        [Test, TestCaseSource("TestCases")]
        public string PrintDiamond_TestCases(int n)
        {
            return new DiamondPrinter().PrintDiamond(n);
        }
    }
}
