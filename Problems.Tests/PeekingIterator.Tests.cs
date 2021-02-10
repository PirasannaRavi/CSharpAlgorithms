using System;
using NUnit.Framework;
using Problems;
using System.Collections.Generic;

namespace Problems.Tests
{
    [TestFixture]
    public class PeekingIteratorTests
    {

        [Test]
        public void PeekingIteratorTest()
        {
            var peekingIterator = new PeekingIterator(new List<int> { 1, 2, 3 }.GetEnumerator());

            var actual = peekingIterator.Next();
            var expected = 1;
            Assert.That(actual, Is.EqualTo(expected));

            actual = peekingIterator.Peek();
            expected = 2;
            Assert.That(actual, Is.EqualTo(expected));

            actual = peekingIterator.Next();
            expected = 2;
            Assert.That(actual, Is.EqualTo(expected));

            actual = peekingIterator.Next();
            expected = 3;
            Assert.That(actual, Is.EqualTo(expected));

            var actual1 = peekingIterator.HasNext();
            var expected1 = false;
            Assert.That(actual1, Is.EqualTo(expected1));
        }
    }
}
