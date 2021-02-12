using System;
using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    [TestFixture]
    public class DeleteNodeLinkedListTests
    {

        [Test]
        public void DeleteNodeLinkedListTest()
        {
            var deleteNodeLinkedList = new DeleteNodeLinkedList();
            var node = new ListNode(5, new ListNode(1, new ListNode(9, null)));
            deleteNodeLinkedList.DeleteNode(node);
        }
    }
}
