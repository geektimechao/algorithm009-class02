using System;
using System.Collections.Generic;
using System.Text;

namespace Week2
{
    public class ToSumClass
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var v = target - nums[i];
                if (dic.ContainsKey(v))
                {
                    return new int[] { dic[v], i };
                }
                else if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            return Array.Empty<int>();
        }
    }
}
