using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Action_Test
    {
        public void Action(string s)
        {
            Console.WriteLine(s);
        }

        public void Action(int i)
        {
            Console.WriteLine(i.ToString());
        }

        public void Test<T>(Action<T> action, T param)
        {
            action(param);
        }

        public Action_Test()
        {
            Test(Action, "GG");

            Test(Action, 1);
        }
    }
}
