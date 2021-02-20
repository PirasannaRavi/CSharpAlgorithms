using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class FibonacciNumberTests
    {

        [Test]
        public void FibonacciNumberTest1()
        {
            var fibonacciNumber = new FibonacciNumber();

            var actual = fibonacciNumber.Fib(5);
            var expected = 5;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FibonacciNumberTest2()
        {
            var fibonacciNumber = new FibonacciNumber();

            var actual = fibonacciNumber.FibMemo(100);
            var expected = 3736710778780434371;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FibonacciNumberTest3()
        {
            var fibonacciNumber = new FibonacciNumber();

            var actual = fibonacciNumber.FibBottomUp(100);
            var expected = 3736710778780434371;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
