using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Search_Insert_Position
    {
        public Search_Insert_Position()
        {

        }
        public int SearchInsert(int[] nums, int target)
        {
            var result = 0;

            foreach(var num in nums)
            {
                if (num >= target)
                {
                    return result;
                }

                result++;
            }

            return result;
        }
    }
}
