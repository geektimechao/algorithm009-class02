using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week01
{
    internal  class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            //尽可能想出更多的解决方案，至少有三种不同的方法可以解决这个问题。
            //要求使用空间复杂度为 O(1) 的 原地 算法。

            //1:暴力 时间复杂度O(n^k)
            for (int j = 0; j < k; j++)
            {
                var preV = nums.Last();
                for (int i = 0; i < nums.Length; i++)
                {
                    int tempV = nums[i];
                    nums[i] = preV;
                    preV = tempV;
                }
            }


            //使用额外控件
            //解题思路：开辟一个同等大小的数组,编辑数组,通过i+k%nums.Length获取新的坐标,赋值进去
            //时间复杂度O(N^2),空间复杂度O(N)
            var indexArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                indexArray[i + k % nums.Length] = nums[i];
            }
            for (int i = 0; i < indexArray.Length; i++)
            {
                nums[i] = indexArray[i];
            }
        }
    }
}
