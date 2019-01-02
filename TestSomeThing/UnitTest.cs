using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class UnitTest
    {
        public UnitTest()
        {
            var input = new int[] { 74, 21, 33, 51, 77, 51, 90, 60, 5, 56 };

            var list = input.ToList();

            list.Sort();
        }
    }
}
