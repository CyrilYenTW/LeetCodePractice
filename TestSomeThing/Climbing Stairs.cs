using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Climbing_Stairs
    {
        public Climbing_Stairs()
        {
            var a = this.ClimbStairs(4);
        }

        public int ClimbStairs(int n)
        {
            if (n < 3)
            {
                return 1;
            }

            n = n + 2;

            var result = 0;
            var leftSum = 0;
            var rightSum = 1;

            for(int i = 2; i < n; i++)
            {
                result = leftSum + rightSum;
                leftSum = rightSum;
                rightSum = result;
            }

            return result;
        }

    }
}
