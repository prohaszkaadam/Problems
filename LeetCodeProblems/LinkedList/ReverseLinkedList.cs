using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LinkedList
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode p = head;
            ListNode k = p;
            ListNode c = p;

            while (p != null && k.next != null)
            {
                k = k.next;

                c.next = k.next;
                k.next = p;
                p = k;
                k = c;
            }
            head = p;
            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
