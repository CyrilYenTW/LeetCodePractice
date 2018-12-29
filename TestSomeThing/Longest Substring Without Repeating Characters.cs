using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    class Longest_Substring_Without_Repeating_Characters
    {
        public Longest_Substring_Without_Repeating_Characters()
        {
            var answer = LengthOfLongestSubstring("cabcdccbad");
        }

        public int LengthOfLongestSubstring(string s)
        {
            var dic = new Dictionary<char, int>();
            var maxLength = 0;
            var headIndex = 0;

            for (int index = 0; index < s.Length; index++)
            {
                var character = s[index];

                if (dic.ContainsKey(character))
                {
                    headIndex = dic[character] < headIndex ? headIndex : dic[character] + 1;

                    dic[character] = index;
                }
                else
                {
                    dic.Add(character, index);
                }

                var nowLength = index - headIndex + 1;

                maxLength = Math.Max(nowLength, maxLength);
            }

            return maxLength;
        }   
    }
}
