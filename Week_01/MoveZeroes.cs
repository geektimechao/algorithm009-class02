using System;
using System.Collections.Generic;
using System.Text;

namespace Week01
{
    /// <summary>
    /// https://leetcode-cn.com/problems/move-zeroes/
    /// </summary>
    public static class MoveZeroe
    {

        public static void MoveZeroes(int[] nums)
        {
            //解法1,复杂度O(n)
            var zeroeCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroeCount++;
                }
                else
                {
                    nums[i - zeroeCount] = nums[i];
                }
            }
            for (int i = 1; i <= zeroeCount; i++)
            {
                nums[^i] = 0;
            }

            //优化版，把值往前挪了后,把自己赋值为0
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroeCount++;
                }
                else
                {
                    var temp = nums[i];
                    nums[i] = 0;
                    nums[i - zeroeCount] = temp;
                }
            }

            //参考官方解答：
            //利用双指针的方法
            for (int fistZeroeIndex = 0, i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    var temp = nums[fistZeroeIndex];
                    nums[fistZeroeIndex] = nums[i];
                    nums[i] = temp;
                    fistZeroeIndex++;
                }
            }
        }
    }
}
