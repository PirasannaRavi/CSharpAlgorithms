using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class MinRemoveToMakeValidTests
    {

        [Test]
        [TestCase("))((","")]
        [TestCase("lee(t(c)o)de)","lee(t(c)o)de")]
        [TestCase("a)b(c)d","ab(c)d")]
        [TestCase("(a(b(c)d)","a(b(c)d)")]
        public void MinRemoveToMakeValidTest(string input, string expected)
        {
            var minimumRemoveToMakeValidParentheses = new MinimumRemoveToMakeValidParentheses();

            var actual = minimumRemoveToMakeValidParentheses.MinRemoveToMakeValid(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
