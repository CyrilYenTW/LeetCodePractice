using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Func_Test
    {
        public int Test<T1, T2>(Func<T1, T2, int> func, T1 a, T2 b)
        {
            return func(a, b);
        }

        public int F1(string a, string b)
        {
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }

        public int F2(int a, int b)
        {
            return a + b;
        }

        public int F3(string a, int b)
        {
            return Convert.ToInt32(a) + b;
        }

        public Func_Test()
        {
            var A = Test(F1, "1", "2");

            var B = Test(F2, 3, 4);

            var C = Test(F3, "5", 6);
        }
    }
}
