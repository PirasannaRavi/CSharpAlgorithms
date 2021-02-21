using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class RomanToIntegerTests
    {

        [Test]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("LVIII", 58)]
        [TestCase("XLII", 42)]
        [TestCase("MCMXCIV", 1994)]
        [TestCase("MDCCCXCIV", 1894)]
        public void RomanToIntegerTest(string input, int expected)
        {
            var romanToInteger = new RomanToInteger();

            var actual = romanToInteger.RomanToIntBetter(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
