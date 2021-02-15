using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class KWeakestRowsInAMatrixTests
    {

        [Test]
        public void KWeakestRowsInAMatrixTest()
        {
            var kWeakestRowsInAMatrix = new KWeakestRowsInAMatrix();
            int[][] arr = new[]{new [] {1,1,0,0,0 },
                                new [] {1,1,1,1,0 },
                                new [] {1,0,0,0,0 },
                                new [] {1,1,0,0,0 },
                                new [] {1,1,1,1,1 }};
            int k = 3;
            var actual = kWeakestRowsInAMatrix.KWeakestRows(arr, k);
            var expected = new[] { 2, 0, 3 };

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
