using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class MergeTwoSortedListsTests
    {

        [Test]
        public void MergeTwoSortedListsTest()
        {
            ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
            ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));

            var mergeTwoSortedLists = new MergeTwoSortedLists();

            var actual = mergeTwoSortedLists.MergeTwoLists(l1, l2);
            ListNode expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, null))))));

            Assert.That(actual, Is.Not.Null);
        }
    }
}
