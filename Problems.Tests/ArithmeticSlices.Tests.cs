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

        [Test]
        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 7)]
        public void ArithmeticSlicesTest2(int[] input, int expected)
        {
            var arithmeticSlices = new ArithmeticSlices();

            var actual = arithmeticSlices.NumberOfSubsequenceArithmeticSlices(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
