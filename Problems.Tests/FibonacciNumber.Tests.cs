using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class FibonacciNumberTests
    {

        [Test]
        public void FibonacciNumberTest()
        {
            var fibonacciNumber = new FibonacciNumber();

            var actual = fibonacciNumber.Fib(4);
            var expected = 3;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
