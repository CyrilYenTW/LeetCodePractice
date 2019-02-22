using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestSomeThing
{
    class Program
    {
        static int Result = 0;

        static void Main(string[] args)
        {

        }

        public int Test(int a)
        {
            if (a > 0)
            {
                if (a >= 100)
                {
                    if ( a >= 1000)
                    {
                        return 1000;
                    }
                    else
                    {
                        return 100;
                    }
                }
                else
                {
                    return a;
                }
            }
            else
            {
                return 0;
            }
        }

        public int Test2(int a)
        {
            if (a >= 1000)
            {
                return 1000;
            }

            if (a >= 100)
            {
                return 100;
            }

            if (a <= 0)
            {
                return 0;
            }

            return a;
        }
    }
}
