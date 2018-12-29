using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Hamming_Distance
    {
        public Hamming_Distance()
        {
            var a = HammingDistance(3, 1);
        }

        public int HammingDistance(int x, int y)
        {
            if (x > y)
            {
                var temp = x;
                x = y;
                y = temp;
            }

            var yString = Convert.ToString(y, 2);
            var xString = Convert.ToString(x, 2).PadLeft(yString.Length, '0');

            var result = 0;

            for (int i = 0; i < xString.Length; i++)
            {
                if (xString[i] != yString[i])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
