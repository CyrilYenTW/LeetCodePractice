using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int index = 0; index < nums.Length; index++)
            {
                if (dic.ContainsKey(target - nums[index]))
                {
                    return new int[] { dic[nums[index]], index };
                }
                else
                {
                    dic.Add(target - nums[index], index);
                }

            }

            return null;
        }
    }
}
