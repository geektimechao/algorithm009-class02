using System;
using System.Collections.Generic;
using System.Text;

namespace Week01
{
    /// <summary>
    /// 两数之和
    /// https://leetcode-cn.com/problems/two-sum/
    /// </summary>
    public static class TwoSum
    {
        public static int[] TwoSumMethod(int[] nums, int target)
        {
            //思路1:暴力解法，复杂度O(n^2)
            for (int i = 0; i < nums.Length; i++)
            {
                var value = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (value == nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }


            //思路2 利用字典 时间复杂度O(n) 空间复杂度O(n)
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    if (nums[i] * 2 == target)
                    {
                        return new int[] { dic[nums[i]], i };
                    }
                }
                else
                {
                    dic.Add(nums[i], i);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                var value = target - nums[i];
                if (dic.ContainsKey(value) && dic[value] != i)
                {
                    return new int[] { i, dic[value] };
                }
            }


            //思路3 减少遍历次数
            var dic1 = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic1.ContainsKey(nums[i]))
                {
                    if (nums[i] * 2 == target)
                    {
                        return new int[] { dic1[nums[i]], i };
                    }
                }
                else
                {
                    var v = target - nums[i];
                    if (dic1.ContainsKey(v))
                    {
                        return new int[] { dic1[v],i };
                    }
                    dic1.Add(nums[i], i);
                }
            }
            return Array.Empty<int>();
        }
    }
}
