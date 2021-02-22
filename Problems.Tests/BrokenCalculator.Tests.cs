using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class BrokenCalculatorTests
    {

        [Test]
        [TestCase(1024, 1, 1023)]
        [TestCase(5, 8, 2)]
        [TestCase(3, 10, 3)]
        [TestCase(2, 9, 6)]
        [TestCase(2, 3, 2)]
        public void BrokenCalculatorTest(int X, int Y, int expected)
        {
            var brokenCalculator = new BrokenCalculator();

            var actual = brokenCalculator.BrokenCalc(X, Y);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
