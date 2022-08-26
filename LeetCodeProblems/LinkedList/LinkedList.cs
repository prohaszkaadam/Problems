using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LinkedList
{
    public class MyLinkedList
    {
        private class Node
        {
            public int val;
            public Node next;
        }
        Node head;
        int count;
        public MyLinkedList()
        {

        }

        public int Get(int index)
        {
            if (index < 0 || index >= count)
            {
                return -1;
            }
            Node p = head; // kell egy copy a headről

            for (int i = 0; i < index; i++)
            {
                p = p.next; // így léptetem
            }

            return p.val;
        }

        public void AddAtHead(int val)
        {
            Node p = head;

            Node newNode = new Node();
            newNode.val = val; // inic
            newNode.next = p;

            head = newNode; // új head lesz a newnode
            count++; // számolni h hány elem van a listben
        }

        public void AddAtTail(int val)
        {
            Node p = head;

            Node newNode = new Node();
            newNode.val = val;
            if (head == null)
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
            }
            count++;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
            }
            else if (index > 0 && index < count)
            {
                // közepe
                Node p = head;

                Node newNode = new Node();
                newNode.val = val;

                for (int i = 0; i < index - 1; i++)
                {
                    p = p.next;
                }
                newNode.next = p.next;
                p.next = newNode;
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
                head = head.next; // a kövi elem lesz az új head
                count--;
            }
            else if (index >= 0 && index < count) // közepe + tail
            {
                Node p = head;
                for (int i = 0; i < index - 1; i++)
                {
                    p = p.next;
                }
                p.next = p.next.next;
                count--;
            }
        }
    }
}
