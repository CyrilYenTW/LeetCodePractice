using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Find_Common_Characters
    {
        public Find_Common_Characters()
        {
            var a = this.CommonChars(new string[] { "cool", "lock", "cook" });
        }

        public IList<string> CommonChars(string[] A)
        {
            var dicIsCheck = new Dictionary<char, bool>();
            var result = new List<string>();

            foreach(var c in A[0])
            {
                if (dicIsCheck.ContainsKey(c) == false)
                {
                    dicIsCheck.Add(c, true);
                }

                if (dicIsCheck[c] == false)
                {
                    continue;
                }

                for (int i = 1; i < A.Length; i++)
                {
                    var indexOf = A[i].IndexOf(c);

                    if (indexOf == -1)
                    {
                        dicIsCheck[c] = false;
                        break;
                    }

                    A[i] = A[i].Remove(indexOf, 1);
                }

                if (dicIsCheck[c] == true)
                {
                    result.Add(c.ToString());
                }
            }

            return result;
        }
    }
}
