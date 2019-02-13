using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Minimum_Add_to_Make_Parentheses_Valid
    {
        public Minimum_Add_to_Make_Parentheses_Valid()
        {
            var input = "())";

            MinAddToMakeValid(input);
        }

        public int MinAddToMakeValid(string S)
        {
            var sLength = S.Length;
            var temp = new char[sLength];
            var index = 0;

            for (int i = 0; i < sLength; i++)
            {
                var current = S[i];

                if (current == ')' && temp[index < 1 ? 0 : index - 1] == '(')
                {
                    index--;

                    if (index < 1)
                    {
                        index = 0;
                        temp[index] = '\0';
                    }

                    continue;
                }

                temp[index] = current;
                index++;
            }

            return index;
        }
    }
}
