using System;
using System.Collections.Generic;
using System.Text;

namespace Week01
{
    public class MyCircularDeque
    {

        List<int> list = null;
        int maxCount = 0;

        /** Initialize your data structure here. Set the size of the deque to be k. */
        public MyCircularDeque(int k)
        {
            list = new List<int>();
            maxCount = k;
        }

        /** Adds an item at the front of Deque. Return true if the operation is successful. */
        public bool InsertFront(int val)
        {
            if (!IsFull())
            {
                list.Insert(0, val);
                return true;
            }
            return false;
        }

        /** Adds an item at the rear of Deque. Return true if the operation is successful. */
        public bool InsertLast(int val)
        {
            if (!IsFull())
            {
                list.Add(val);
                return true;
            }
            return false;
        }

        /** Deletes an item from the front of Deque. Return true if the operation is successful. */
        public bool DeleteFront()
        {
            if (list.Count > 0)
            {
                list.RemoveAt(0);
                return true;
            }
            return false;
        }

        /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
        public bool DeleteLast()
        {
            if (list.Count > 0)
            {
                list.RemoveAt(list.Count - 1);
                return true;
            }
            return false;
        }

        /** Get the front item from the deque. */
        public int GetFront()
        {
            if (list.Count > 0)
            {
                return list[0];
            }
            return -1;
        }

        /** Get the last item from the deque. */
        public int GetRear()
        {
            if (list.Count > 0)
            {
                return list[list.Count - 1];
            }
            return -1;
        }

        /** Checks whether the circular deque is empty or not. */
        public bool IsEmpty()
        {
            if (list.Count == 0)
            {
                return true;
            }
            return false;
        }

        /** Checks whether the circular deque is full or not. */
        public bool IsFull()
        {
            if (list.Count == maxCount)
            {
                return true;
            }
            return false;
        }
    }
}
