using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LinkedList
{
    public class DoublyLinkedList
    {
        public class DoublyNode
        {
            public int val;
            public DoublyNode next, prev;

            public DoublyNode(int val)
            {
                this.val = val;
            }
        }

        DoublyNode head;
        int count;

        public int Get(int index)
        {
            if (index < 0 || index >= count)
            {
                return -1;
            }
            DoublyNode p = head;

            for (int i = 0; i < index; i++)
            {
                p = p.next;
            }

            return p.val;
        }

        public void AddAtHead(int val)
        {
            DoublyNode p = head;

            DoublyNode newNode = new DoublyNode(val);
            if (p != null)
            {
                newNode.next = p;
                p.prev = newNode;
            }
            else
            {
                newNode.next = p;
            }
            

            head = newNode;

            count++;
        }

        public void AddAtTail(int val)
        {
            DoublyNode p = head;

            DoublyNode newNode = new DoublyNode(val);
            if (head == null) // if linked list is empty
            {
                head = newNode;
            }
            else
            {
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = newNode;
                newNode.prev = p;
            }
            count++;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
            }
            else if (index > 0 && index < count) // center of the linked list
            {
                DoublyNode p = head;

                DoublyNode newNode = new DoublyNode(val);

                for (int i = 0; i < index; i++)
                {
                    p = p.next;
                }
                DoublyNode k = p.prev;
                k.next = newNode; // = p.prev.next = newNode;
                p.prev = newNode;                
                newNode.prev = k; // = newNode.prev = p.prev;
                newNode.next = p;

                count++;
            }
            else if (index == count)
            {
                AddAtTail(val);
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (index == 0 && count > 0)
            {
                head = head.next;
                if (head != null)
                {
                    head.prev = null;
                }
                count--;
            }
            else if (index >= 0 && index < count)
            {
                DoublyNode p = head;
                for (int i = 0; i < index; i++)
                {
                    p = p.next;
                }
                if (p.next != null)
                {
                    p.next.prev = p.prev; // center
                    p.prev.next = p.next;
                }
                else
                {
                    p.prev.next = null; // tail
                    p.prev = null;
                }
            
                count--;
            }
        }
    }
}
