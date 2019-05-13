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
            var a = this.solution(1000);
        }

        public int solution(int N)
        {
            var str = Math.Pow(11, N).ToString();

            /*
            if (N < 2)
            {
                return N == 0 ? 1 : 2;
            }

            var str = "11";

            for(int i = 1; i < N; i++)
            {
                var newStr = "1";
                var isAdd = false;

                for(var index = 0; index < str.Length - 1; index++)
                {
                    var sum = Convert.ToInt32(str[index].ToString()) + Convert.ToInt32(str[index + 1].ToString()) + (isAdd ? 1 : 0);

                    isAdd = sum > 9 ? true : false;

                    var newChar = (sum % 10).ToString();

                    newStr += newChar;
                }

                str = newStr + (Convert.ToInt32(str.Last().ToString()) + (isAdd ? 1 : 0)).ToString();
            }
            */
            return str.Split('1').Length - 1;
        }
    }
}
