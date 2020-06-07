using System;
using System.Collections.Generic;
using System.Text;

namespace Week3
{
    public class LetterCombination
    {
        static readonly string[] Phone = new string[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        public IList<string> LetterCombinations(string digits)
        {
            var digitArray = digits.ToCharArray();
            var wordsCount = digitArray.Length == 0 ? 0 : 1;
            var baseNum = new int[digitArray.Length];
            for (int i = digitArray.Length - 1; i >= 0; i--)
            {
                baseNum[i] = wordsCount;
                wordsCount *= Phone[digitArray[i] - '2'].Length;
            }
            var result = new List<string>(wordsCount);
            var word = new char[digitArray.Length];
            for (int num = 0; num < wordsCount; num++)
            {
                for (int i = 0; i < digitArray.Length; i++)
                {
                    var letters = Phone[digitArray[i] - '2'];
                    word[i] = letters[num / baseNum[i] % letters.Length];
                }
                result.Add(new string(word));
            }
            return result;
        }
    }
}
