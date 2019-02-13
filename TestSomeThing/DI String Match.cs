using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class DI_String_Match
    {
        public DI_String_Match()
        {
            var input = "IDDI";

            DiStringMatch(input);
        }

        public int[] DiStringMatch(string S)
        {
            var sLength = S.Length;
            var head = 0;
            var tail = sLength;
            var result = new int[sLength + 1];

            for (int i = 0; i < sLength; i++)
            {
                var current = S[i];

                result[i] = current == 'I' ? head++ : tail--;
            }

            result[sLength] = tail;

            return result;
        }
    }
}
