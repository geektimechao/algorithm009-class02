using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveZeroes(new int[] { 1, 2, 0 });
            RemoveOuterParentheses("()()");
            MaxSlidingWindow(new int[] { 1, -1, 3, 4, 5, 6, 7 }, 2);
            global::System.Console.WriteLine(3 < 3);
            global::System.Console.ReadLine();
            Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
        }

        public static int getKthMagicNumber(int k)
        {
            int p3 = 0, p5 = 0, p7 = 0;
            int[] dp = new int[k];
            dp[0] = 1;
            for (int i = 1; i < k; i++)
            {
                dp[i] = Math.Min(dp[p3] * 3, Math.Min(dp[p5] * 5, dp[p7] * 7));
                if (dp[i] == dp[p3] * 3) p3++;
                if (dp[i] == dp[p5] * 5) p5++;
                if (dp[i] == dp[p7] * 7) p7++;
            }
            return dp[k - 1];
        }

       

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums.Length < 3) return Array.Empty<List<int>>();
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            HashSet<string> resHash = new HashSet<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) break ;
                if (i > 0 && nums[i] == nums[i - 1]) continue; // 去重
                int left = i + 1, right = nums.Length - 1;
                if (left >= nums.Length) break;
                var tag = -(nums[i]);
                while (left < right)
                {
                    if (nums[left] + nums[right] == tag && !resHash.Contains(nums[i] + "" + nums[left] + "" + nums[right]))
                    {
                        res.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        resHash.Add(nums[i] + "" + nums[left] + "" + nums[right]);
                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }

                        //No need to look at the same number if its already is in the result.
                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }

                        left++;
                        right--;
                    }
                    else if (nums[left] + nums[right] > tag)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
            return res;
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            var res = new int[nums.Length];
            int zeroCount = 0, sum = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                _ = nums[i] == 0 ? zeroCount++ : sum *= nums[i];
                if (zeroCount > 1)
                {
                    return res;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (zeroCount == 1 && nums[i] != 0)
                {
                    res[i] = 0;
                }
                else if (nums[i] == 0)
                {
                    res[i] = sum;
                }
                else
                {
                    res[i] = sum / nums[i];
                }
            }
            return res;
        }

        public static int[] ReversePrint(ListNode head)
        {
            Stack<int> q = new Stack<int>();
            var cur = head;
            while (cur != null)
            {
                q.Push(cur.val);
                cur = cur.next;
            }
            var res = new List<int>();
            while (q.Count != 0)
            {
                res.Add(q.Pop());
            }
            return res.ToArray();
        }

        public static string ReplaceSpace(string s)
        {
            return s.Replace(" ", "%20");
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> trees = new Stack<TreeNode>();
            var cur = root;
            while (cur != null || trees.Count != 0)
            {
                while (cur != null)
                {
                    trees.Push(cur.left);
                    cur = cur.left;
                }
                if (trees.TryPop(out cur))
                {
                    res.Add(cur.val);
                    cur = cur.right;
                }

            }
            return res;
        }



        public static void MoveZeroes(int[] nums)
        {
            for (int numIndex = 0, i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    var temp = nums[numIndex]; ;
                    nums[numIndex++] = nums[i];
                    nums[i] = temp;
                }
            }
        }

        public static string RemoveOuterParentheses(string S)
        {
            var q = new LinkedList<char>();
            var result = "";
            int left = 0, right = 0;
            for (int i = 0; i < S.Length; i++)
            {
                q.AddLast(S[i]);
                _ = (S[i] == '(' ? ++left : ++right);
                if (left == right)
                {
                    q.RemoveFirst();
                    q.RemoveLast();
                    while (q.Count > 0)
                    {
                        result += q.First.Value;
                        q.RemoveFirst();
                    }
                    right = 0;
                    left = 0;
                }
            }
            return result;
        }

        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (k == 0) return nums;

            var len = nums.Length;

            var result = new int[len - k + 1];

            var link = new LinkedList<int>();

            for (int i = 0; i < nums.Length - k + 1; i++)
            {
                if (link.Count > 0 && link.First.Value + k <= i)
                {
                    link.RemoveFirst();
                }
                while (link.Count > 0 && nums[link.Last.Value] <= nums[i])
                {
                    link.RemoveLast();
                }
                link.AddLast(i);
                int index = i + 1 - k;
                if (index >= 0)
                {
                    result[index] = nums[link.First.Value];
                }
            }
            return result;

            //if (k == 0) return nums;
            //int len = nums.Length;
            //int maxArrayLen = len - k + 1;
            //int[] ans = new int[maxArrayLen];
            //LinkedList<int> q = new LinkedList<int>();
            ////队列存储数组的索引，值在减少命令。所以，队列中的第一个节点是窗口中的最大值
            //for (int i = 0; i < len; i++)
            //{
            //    // 1. 从头部移除元素，直到窗口中的第一个数字
            //    if (q.Count > 0 && q.First.Value + k <= i)
            //    {
            //        q.RemoveFirst();
            //    }
            //    // 2. 在将i插入队列之前，请从值较小的队列索引数组[i]
            //    while (q.Count > 0 && nums[q.Last.Value] <= nums[i])
            //    {
            //        q.RemoveLast();
            //    }
            //    q.AddLast(i);
            //    // 3. 在窗口中设置最大值（始终是队列中的第一个数字）
            //    int index = i + 1 - k;
            //    if (index >= 0)
            //    {
            //        ans[index] = nums[q.First.Value];
            //    }
            //}

            //return ans;

            //if (nums.Length < k) return new int[0];
            //var result = new int[nums.Length - k + 1];
            //#region 暴力解法,超出时间限制
            ////var resultIndex = 0;
            ////for (int i = 0; i < nums.Length - k + 1; i++)
            ////{
            ////    var max = nums[i];
            ////    for (int j = 0; j < k; j++)
            ////    {
            ////        max = Math.Max(nums[j + i], max);
            ////    }
            ////    result[resultIndex++] = max;
            ////} 
            //#endregion

            //return result;
        }


        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var dic1 = new Dictionary<int, int>();
            var dic2 = new Dictionary<int, int>();
            void _initDic(int[] nums, Dictionary<int, int> dic)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (dic.ContainsKey(nums[i]))
                    {
                        dic[nums[i]] = ++dic[nums[i]];
                    }
                    else
                    {
                        dic[nums[i]] = 1;
                    }
                }
            }

            _initDic(nums1, dic1);
            _initDic(nums2, dic2);

            var result = new List<int>();

            foreach (var item in dic2.Count > dic1.Count ? dic1 : dic2)
            {
                if ((dic2.Count > dic1.Count ? dic2 : dic1).ContainsKey(item.Key))
                {
                    var tempv1 = dic2[item.Key];
                    var temp2 = dic1[item.Key];

                    for (int i = 0; i < Math.Min(tempv1, temp2); i++)
                    {
                        result.Add(item.Key);
                    }
                }
            }

            return result.ToArray();


            //var eachNum = nums1.Length > nums2.Length ? nums2 : nums1;
            //var compareNum = nums1.Length > nums2.Length ? nums1 : nums2;
            //var hash = new HashSet<int>();
            //var result = new List<int>();
            //for (int i = 0; i < eachNum.Length; i++)
            //{
            //    for (int j = 0; j < compareNum.Length; j++)
            //    {
            //        if (eachNum[i] == compareNum[j] && !hash.Contains(j))
            //        {
            //            result.Add(eachNum[i]);
            //            hash.Add(j);
            //            break;
            //        }
            //    }
            //}
            //return result.ToArray();
        }

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var eachNum = nums1.Length > nums2.Length ? nums1 : nums2;
            HashSet<int> compareHash = new HashSet<int>(nums1.Length > nums2.Length ? nums2 : nums1);
            HashSet<int> result = new HashSet<int>();
            foreach (var item in eachNum)
            {
                if (compareHash.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

}
