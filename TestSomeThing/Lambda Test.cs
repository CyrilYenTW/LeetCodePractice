using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Lambda_Test
    {
        Func<int, int, int> AddMethod = (int x, int y) => x + y;

        Func<string, string, string> AddMethod2 = (string x, string y) => x + y;

        public Lambda_Test()
        {
            var a = Test(AddMethod, 1, 2);

            var b = Test(AddMethod2, "1", "2");
        }

        public string Test<T1, T2, T3> (Func<T1, T2, T3> func, T1 a, T2 b)
        {
            return func(a, b).ToString();
        }
    }

    public class Test<T1, T2>
    {
        public Func<T1, T2, string> F1 = (x, y) => x.ToString() + y.ToString();

        public string Result { get; set; }

        public Test(T1 a, T2 b)
        {
            Result = F1(a, b);
        }
    }
}
