using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Delagete_Test
    {
        public delegate string DoMethod(string method);

        public Delagete_Test()
        {
            var sourceString = "AbCdefGh";

            var a = ProcessWithMethod(sourceString, LowerMethod);

            var b = ProcessWithMethod(sourceString, UpperMethod);
        }

        public string ProcessWithMethod(string sourceString, DoMethod dm)
        {
            return dm(sourceString);
        }

        public string LowerMethod(string s)
        {
            return s.ToLower();
        }

        public string UpperMethod(string s)
        {
            return s.ToUpper();
        }
    }
}
