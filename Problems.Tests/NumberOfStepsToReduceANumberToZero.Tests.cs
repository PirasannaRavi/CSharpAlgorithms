using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class NumberOfStepsToReduceANumberToZeroTests
    {

        [Test]
        [TestCase(14, 6)]
        [TestCase(8, 4)]
        [TestCase(123, 12)]
        public void NumberOfStepsToReduceANumberToZeroTest(int num, int expected)
        {
            var numberOfStepsToReduceANumberToZero = new NumberOfStepsToReduceANumberToZero();

            var actual = numberOfStepsToReduceANumberToZero.NumberOfSteps(num);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
