using System;
using System.Collections.Generic;
using System.Text;

namespace Week3
{
    public  class MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int countTreshold = nums.Length / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
                if (dict[nums[i]] > countTreshold)
                {
                    return nums[i];
                }
            }
            return -1;
        }
    }
}
