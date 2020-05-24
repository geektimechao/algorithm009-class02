using System;
using System.Collections.Generic;
using System.Text;

namespace Week01
{
    /// <summary>
    /// 和合并两个有序数组
    /// https://leetcode-cn.com/problems/merge-sorted-array/
    /// </summary>
    public static class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //思路1：
            //先合并两个数组,然后使用冒泡排序进行排序
            //时间复杂度O(n^2)
            Array.Copy(nums2, 0, nums1, m, n);
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = i + 1; j < nums1.Length; j++)
                {
                    if (nums1[i] > nums1[j])
                    {
                        var temp = nums1[j];
                        nums1[j] = nums1[i];
                        nums1[i] = temp;
                    }
                }
            }

            //思路2
        }
    }
}
