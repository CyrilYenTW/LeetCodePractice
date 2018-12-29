using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Jewels_and_Stones
    {
        public Jewels_and_Stones()
        {
            var J = "aA";

            var S = "aAAvvvv";

            var a = NumJewelsInStones(J, S);


        }

        public int NumJewelsInStones(string J, string S)
        {
            var sDic = new Dictionary<char, int>();

            for (int i = 0; i < S.Length; i++)
            {
                var character = S[i];

                sDic[character] = sDic.ContainsKey(character) ? sDic[character] + 1 : 1;
            }

            var result = 0;

            for (int i = 0; i < J.Length; i++)
            {
                result = sDic.ContainsKey(J[i]) ? result + sDic[J[i]] : result;
            }

            return result;
        }
    }
}
