using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Remove_Duplicates_from_Sorted_Array
    {
        public Remove_Duplicates_from_Sorted_Array()
        {

        }

        public int RemoveDuplicates(int[] nums)
        {
            var result = new Dictionary<int, int>();
            var resultList = new List<int>();

            foreach (var num in nums)
            {
                if (result.ContainsKey(num))
                {
                    continue;
                }

                result.Add(num, 0);
                resultList.Add(num);
            }

            nums = resultList.OrderBy(m => m).ToArray();

            return result.Keys.Count;
        }
    }
}
