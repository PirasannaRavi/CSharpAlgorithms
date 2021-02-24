using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class ScoreOfBalancedParenthesesTests
    {

        [Test]
        [TestCase("()(()((())))", 11)]
        [TestCase("()()", 2)]
        [TestCase("(())", 2)]
        [TestCase("()", 1)]
        [TestCase("(()(()))", 6)]
        public void ScoreOfBalancedParenthesesTest(string S, int expected)
        {
            var scoreOfBalancedParentheses = new ScoreOfBalancedParentheses();

            var actual = scoreOfBalancedParentheses.ScoreOfParentheses(S);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
