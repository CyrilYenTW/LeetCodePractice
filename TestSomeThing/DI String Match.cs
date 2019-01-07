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
            var head = 0;
            var tail = S.Length;
            var result = new int[S.Length + 1];

            for (int i = 0; i < S.Length; i++)
            {
                var current = S[i];

                result[i] = current == 'I' ? head++ : tail--;
            }

            result[S.Length] = tail;

            return result;
        }
    }
}
