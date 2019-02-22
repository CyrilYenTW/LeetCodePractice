using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestSomeThing
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = 1000;
            var rightCount = 0;

            for (int i = 0; i < testCount; i++)
            {
                var temp = new ThreeDoorChange();

                temp.FirstChoosing();

                if (temp.Change())
                {
                    rightCount++;
                }
            }

            var result = (double)(rightCount*100) / testCount;

            Console.WriteLine(string.Format("{0}%", result.ToString()));

            Console.ReadLine();
        }
    }
}
