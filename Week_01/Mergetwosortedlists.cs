using System;
using System.Collections.Generic;
using System.Text;

namespace Week01
{
    /// <summary>
    /// https://leetcode-cn.com/problems/merge-two-sorted-lists/
    /// </summary>
    public static class Mergetwosortedlists
    {
        //合并两个有序链表
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null||l2==null)
            {
                return l1 ?? l2;
            }
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l2.next, l1);
                return l2;
            }
        }
    }
}
