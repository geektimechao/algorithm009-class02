using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Week01
{
    internal class RemoveDuplicate
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;
            var cur = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[cur] != nums[i])
                {
                    cur++;
                    nums[cur] = nums[i];
                }
               
            }
            return cur + 1;
        }
    }
}
