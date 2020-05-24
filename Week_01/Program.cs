using System;

namespace Week01
{
    class Program
    {
        static void Main(string[] args)
        {
            //删除排序数组中的重复项
            //RemoveDuplicate remove = new RemoveDuplicate();
            //remove.RemoveDuplicates(new int[] { 0, 0, 0, 0, 0 });

            //旋转数组
            //new RotateArray().Rotate(new int[] { 0, 1, 2, 3 }, 1);

            //合并两个数组
            //MergeSortedArray.Merge(new int[] { 1, 2, 3, 0, 0, 0 },3, new int[] { 2, 5, 6 },3);

            //加一
            //foreach (var item in PlusOne.PlusOneFunc(new int[] { 1,2,9 }))
            //{
            //    Console.WriteLine(item);
            //}

            MyCircularDeque circularDeque = new MyCircularDeque(3); // 设置容量大小为3
            Console.WriteLine("true:" + circularDeque.InsertLast(1));// 返回 true
            Console.WriteLine("true:" + circularDeque.InsertLast(2));                    // 返回 true
            Console.WriteLine("true:" + circularDeque.InsertFront(3)); ;                   // 返回 true
            Console.WriteLine("false:" + circularDeque.InsertFront(4));                   // 已经满了，返回 false
            Console.WriteLine("2:" + circularDeque.GetRear()); ;                // 返回 2
            Console.WriteLine("true:" + circularDeque.IsFull()); ;                     // 返回 true
            Console.WriteLine("true:" + circularDeque.DeleteLast()); ;                 // 返回 true
            Console.WriteLine("true:" + circularDeque.InsertFront(4));                   // 返回 true
            Console.WriteLine("4:" + circularDeque.GetFront());               // 返回 4

            //circularDeque.InsertFront(5);
            //circularDeque.InsertLast(7);
            //circularDeque.GetFront();
            //circularDeque.InsertLast(0);
            //circularDeque.GetFront();
            //circularDeque.InsertFront(9);
            //circularDeque.GetFront();
            //circularDeque.GetFront();
            //circularDeque.GetFront();
            //circularDeque.GetFront();
            //circularDeque.DeleteFront();
            //circularDeque.DeleteLast();
            //circularDeque.GetRear();

            circularDeque.InsertLast(1);
            circularDeque.InsertLast(2);
            circularDeque.InsertLast(3);

            Console.ReadLine();

        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode pre;
        public ListNode(int x) { val = x; }
    }
}
