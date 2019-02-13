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
            //var a = GetResult(10000);

            var a = "　aaxxvv ";
            var b = a.Trim();
        }

        public static string GetResult(decimal n)
        {
            var result = "1";
            
            for (int count = 0; count < n; count++)
            {
                var temp = result;
                var isCarry = false;
                result = string.Empty;

                for (var index = 0; index < temp.Length; index++)
                {
                    var digit = Convert.ToInt32(temp[index].ToString()) * 2;

                    digit = isCarry ? digit + 1 : digit;

                    isCarry = digit > 9 ? true : false;

                    result += (digit % 10).ToString();
                }

                result = isCarry ? result += "1" : result;

            }

            var resultArray = result.ToCharArray();

            Array.Reverse(resultArray);

            return new string(resultArray);
        }
    }
}
