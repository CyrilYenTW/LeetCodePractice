using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Maximum_Subarray
    {
        public Maximum_Subarray()
        {
            this.MaxSubArray(new int[] { -1, -2 });
        }

        public int MaxSubArray(int[] nums)
        {
            var max = int.MinValue;
            var headIndex = 0;
            var tailIndex = headIndex;
            var sum = 0;
            var numsLength = nums.Length;

            while (headIndex < numsLength)
            {
                if(headIndex == numsLength - 1)
                {
                    return Math.Max(max, nums[headIndex]);
                }

                sum = sum + nums[tailIndex];
                max = Math.Max(max, sum);

                if (sum < 1 || tailIndex == numsLength)
                {
                    headIndex++;
                    tailIndex = headIndex;
                    sum = 0;
                    continue;
                }

                tailIndex++;

                if (tailIndex == numsLength)
                {
                    headIndex++;
                    tailIndex = headIndex;
                    sum = 0;
                    continue;
                }
            }

            return max;
        }
    }
}
