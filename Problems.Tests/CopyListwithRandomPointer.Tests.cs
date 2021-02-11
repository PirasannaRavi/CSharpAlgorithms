using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class CopyListwithRandomPointerTests
    {

        [Test]
        public void CopyListwithRandomPointerTest()
        {
            var node1 = new Node(7);
            var node2 = new Node(13);
            var node3 = new Node(11);
            var node4 = new Node(10);
            var node5 = new Node(1);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            node1.random = null;
            node2.random = node1;
            node2.random = node5;
            node2.random = node3;
            node2.random = node1;


            var copyListwithRandomPointer = new CopyListwithRandomPointer();
            var actual = copyListwithRandomPointer.CopyRandomList(node1);

            Assert.That(actual, Is.Not.Null);
        }
    }
}
