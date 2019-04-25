using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Longest_Common_Prefix
    {
        public Longest_Common_Prefix()
        {
            var temp = new string[] { "flower", "flow", "flight" };

            var result = this.LongestCommonPrefix2(temp);
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 2)
            {
                return strs.Length == 1 ? strs[0] : "";
            }

            var tempArr = strs.OrderBy(m => m).ToArray();
            var result = tempArr[0];


            for (int i=1; i<tempArr.Length; i++)
            {
                for(int index=0; index<result.Length; index++)
                {
                    if (index==0 && result[index] != tempArr[i][index])
                    {
                        return "";
                    }

                    if (result[index] == tempArr[i][index])
                    {
                        continue;
                    }

                    result = result.Substring(0, index);
                }
            }

            return result;
        }

        public string LongestCommonPrefix2(string[] strs)
        {
            if (strs.Length < 2)
            {
                return strs.Length == 1 ? strs[0] : "";
            }

            var result = strs[0];

            foreach(var temp in strs)
            {
                while(temp.StartsWith(result) == false)
                {
                    result = result.Substring(0, result.Length - 1);

                    if (result == "")
                    {
                        return result;
                    }
                }
            }

            return result;
        }
    }
}
