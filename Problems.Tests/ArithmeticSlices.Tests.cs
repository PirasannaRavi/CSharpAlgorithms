using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class ArithmeticSlicesTests
    {

        [Test]
        [TestCase(new int[] { 1, 2, 3, 5, 6, 7 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        public void ArithmeticSlicesTest(int[] input, int expected)
        {
            var arithmeticSlices = new ArithmeticSlices();

            var actual = arithmeticSlices.NumberOfConsecutiveArithmeticSlices(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
