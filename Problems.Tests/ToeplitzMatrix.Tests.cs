using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class ToeplitzMatrixTests
    {

        [Test]
        public void ToeplitzMatrixTest()
        {
            var toeplitzMatrix = new ToeplitzMatrix();
            var matrix = new[]{new []{ 12, 23, -32 },
                               new []{ -20, 12, 23 },
                               new []{ 56, -20, 12 },
                               new []{ 38, 56, -20 }};
            var actual = toeplitzMatrix.IsToeplitzMatrix(matrix);
            var expected = true;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
