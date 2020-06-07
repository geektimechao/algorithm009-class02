using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2
{
    public class GroupAnagramsClass
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                var orderStr = strs[i].OrderBy(c => c).Aggregate("",(c,b)=>c+b);
                if (dic.ContainsKey(orderStr))
                {
                    dic[orderStr].Add(strs[i]);
                }
                else
                {
                    dic.Add(orderStr, new List<string>() { strs[i] });
                }
            }
            return dic.Select(c => c.Value).ToList();
        }


        private static int GetCharSum(string str)
        {
            var sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += str[i] - 'a';
            }
            return sum;
        }
    }
}
