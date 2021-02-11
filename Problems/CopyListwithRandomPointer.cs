using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    public class CopyListwithRandomPointer
    {
        Node newHead = null;
        Node newHeadCopy = null;
        Node previousNode = null;
        Node previousNodeCopy = null;
        public Node CopyRandomList(Node head)
        {
            if (head != null)
            {
                var newNode = new Node(head.val);
                var newNodeCopy = new Node(head.val);

                newNode.random = head;
                newNodeCopy.random = head;

                previousNode = newNode;
                previousNodeCopy = newNodeCopy;

                if (newHead == null)
                {
                    newHead = newNode;
                    newHeadCopy = newNodeCopy;
                }

                MakeNode(head.next);
                AlterNode(head, newHead, newHead, newHeadCopy);

                return newHead;
            }
            return null;
        }

        public void MakeNode(Node head)
        {
            if (head != null)
            {
                var newNode = new Node(head.val);
                var newNodeCopy = new Node(head.val);

                newNode.random = head;
                newNodeCopy.random = head;

                previousNode.next = newNode;
                previousNodeCopy.next = newNodeCopy;

                previousNode = newNode;
                previousNodeCopy = newNodeCopy;

                MakeNode(head.next);
            }
        }
        public void AlterNode(Node oldHead, Node newHead, Node nextNodeToAlter, Node nextNodeToRefer)
        {
            if (nextNodeToAlter != null)
            {
                var oldNode = searchOldHead(nextNodeToAlter.random.random, oldHead);
                nextNodeToAlter.random = searchNewHead(oldNode, newHead, nextNodeToRefer);
                AlterNode(oldHead, newHead, nextNodeToAlter.next, nextNodeToRefer);
            }
        }

        public Node searchOldHead(Node nodeToSearch, Node oldHead)
        {
            if (nodeToSearch == null)
            {
                return null;
            }
            else if (nodeToSearch.Equals(oldHead))
            {
                return oldHead;
            }
            return searchOldHead(nodeToSearch, oldHead.next);
        }

        public Node searchNewHead(Node nodeToSearch, Node newHead, Node headToRefer)
        {
            if (nodeToSearch == null)
            {
                return null;
            }
            else if (nodeToSearch.Equals(headToRefer.random))
            {
                return newHead;
            }
            return searchNewHead(nodeToSearch, newHead.next, headToRefer.next);
        }
    }
}
