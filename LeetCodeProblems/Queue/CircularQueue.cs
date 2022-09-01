using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Queue
{
    public class CircularQueue // also "Ring Buffer"
    {
        int[] queue;
        int head;
        int tail;
        int i = 0;

        public CircularQueue(int k)
        {
            queue = new int[k];

            for (int i = 0; i < queue.Length; i++)
            {
                queue[i] = int.MaxValue;
            }
        }

        public bool EnQueue(int value)
        {
            if (IsEmpty())
            {
                if (i == queue.Length)
                {
                    i = 0;
                    head = i;
                    tail = i;
                }

                queue[i] = value;
                head = i;
                tail = i;
                i++;

                return true;
            }
            else if (!IsFull())
            {
                if (tail == queue.Length - 1)
                {
                    tail = 0;
                    i = 0;
                    queue[tail] = value;
                    i++;
                }
                else
                {
                    queue[i] = value;
                    tail = i;
                    i++;
                }
                return true;
            }
            return false;
        }

        public bool DeQueue()
        {
            if (!IsEmpty())
            {
                if (head == queue.Length - 1)
                {
                    queue[head] = int.MaxValue;
                    head = 0;
                }
                else
                {
                    queue[head] = int.MaxValue;
                    head++;
                }
                return true;
            }
            return false;
        }

        public int Front()
        {
            return IsEmpty() ? -1 : queue[head];
        }

        public int Rear()
        {
            return IsEmpty() ? -1 : queue[tail];
        }

        public bool IsEmpty()
        {
            for (int i = 0; i < queue.Length; i++)
            {
                if (queue[i] != int.MaxValue)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsFull()
        {
            for (int i = 0; i < queue.Length; i++)
            {
                if (queue[i] == int.MaxValue)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
