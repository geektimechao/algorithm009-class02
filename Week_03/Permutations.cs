using System;
using System.Collections.Generic;
using System.Text;

namespace Week3
{
    public  class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {

            IList<IList<int>> res = new List<IList<int>>();
            LinkedList<int> track = new LinkedList<int>(); 
            backrack(nums, track, res);
            return res;
        }

        public static void backrack(int[] nums, LinkedList<int> track, IList<IList<int>> res)
        {
            if (track.Count == nums.Length)
            {
                res.Add(new List<int>(track)); 
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (track.Contains(nums[i])) 
                {
                    continue; ;
                }
                track.AddLast(nums[i]);
                backrack(nums, track, res);
                track.RemoveLast();
            }
        }
    }
}
