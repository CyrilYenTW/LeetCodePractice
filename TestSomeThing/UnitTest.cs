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
            var target = "e";

            var result = (int)target.ToUpper()[0] - 'A';
        }
    }
}
