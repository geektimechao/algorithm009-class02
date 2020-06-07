using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2
{
    public class IsAnagramClass
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var res = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                res[s[i] - 'a']++;
                res[t[i] - 'a']--;
            }
            return res.All(c => c == 0);

            //return true;
        }
    }
}
