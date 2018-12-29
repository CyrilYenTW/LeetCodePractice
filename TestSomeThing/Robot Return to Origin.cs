using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Robot_Return_to_Origin
    {
        public Robot_Return_to_Origin()
        {
            var a = JudgeCircle("RLUURDDDLU");
        }

        public bool JudgeCircle(string moves)
        {
            var x = 0;
            var y = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'U':
                        y++;
                        break;
                    case 'D':
                        y--;
                        break;
                    case 'R':
                        x++;
                        break;
                    case 'L':
                        x--;
                        break;
                }
            }

            return x == 0 && y == 0;
        }
    }
}
