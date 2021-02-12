using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class DeleteNodeLinkedList
    {
        public void DeleteNode(ListNode node)
        {
            ListNode previousNode = null;
            while (true)
            {
                node.val = node.next.val;
                previousNode = node;
                node = node.next;
                if (node.next == null)
                {
                    previousNode.next = null;
                    break;
                }
            }
        }
    }
}
