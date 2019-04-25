using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Count_and_Say
    {
        public Count_and_Say()
        {
            this.CountAndSay(4);
        }

        public string CountAndSay(int n)
        {
            var result = string.Empty;

            for(int i=0; i<n; i++)
            {
                result = this.GetNextString(result);
            }

            return result;
        }

        public string GetNextString(string input)
        {
            var result = string.Empty;

            if (input == string.Empty)
            {
                return "1";
            }

            var counter = 1;

            for(int i=0; i<input.Length; i++)
            {
                if (i == input.Length-1)
                {
                    result += counter.ToString() + input[i].ToString();
                    continue;
                }

                if (input[i] != input[i + 1])
                {
                    result += counter.ToString() + input[i].ToString();
                    counter = 1;
                    continue;
                }

                counter++;
            }

            return result;
        }
    }
}
