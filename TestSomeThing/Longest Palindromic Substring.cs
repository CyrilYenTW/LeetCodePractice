using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Longest_Palindromic_Substring
    {
        public Longest_Palindromic_Substring()
        {
            var a = LongestPalindrome("ppadmmdao");

            
        }

        public string LongestPalindrome(string s)
        {
            if (s.Length < 2) return s;
            int m = 0;
            string longest = "";
            while (m < s.Length - 1)
            {
                var l = m;
                while (m < s.Length - 1 && s[m + 1] == s[m])
                {
                    m++;
                }
                var r = m;
                while (l > 0 && r < s.Length - 1 && s[l - 1] == s[r + 1])
                {
                    l--;
                    r++;
                }
                var cur = s.Substring(l, r - l + 1);
                if (cur.Length > longest.Length) longest = cur;
                m++;
            }
            return longest;
        }

        public string LongestPalindrome2(string s)
        {
            if (s.Length < 1)
            {
                return "";
            }

            var result = string.Empty;
            var headIndex = 0;
            var tailIndex = s.Length - 1;

            while (result.Length <= s.Length - headIndex)
            {
                var temp = GetPalindromicString(s, headIndex, tailIndex);

                result = result.Length >= temp.Length ? result : temp;

                headIndex++;
            }

            return result;
        }

        public string GetPalindromicString(string s, int headIndex, int tailIndex)
        {
            var tempTailIndex = tailIndex;

            while (IsPalindromicString(s, headIndex, tempTailIndex) == false)
            {
                tempTailIndex--;
            }

            return s.Substring(headIndex, tempTailIndex - headIndex + 1);
        }

        public bool IsPalindromicString(string s, int headIndex, int tailIndex)
        {
            if (s[headIndex] == s[tailIndex])
            {
                if (headIndex == tailIndex || tailIndex - headIndex == 1)
                {
                    return true;
                }
                else
                {
                    return IsPalindromicString(s, headIndex + 1, tailIndex - 1);
                }
            }
            else
            {
                return false;
            }
        }
    }
}
