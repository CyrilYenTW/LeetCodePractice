using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Delete_Columns_to_Make_Sorted
    {
        public Delete_Columns_to_Make_Sorted()
        {
            var input = new string[]{ "a", "b" };

            MinDeletionSize(input);
        }

        public int MinDeletionSize(string[] A)
        {
            var rowCount = A.Length;
            var colCount = A[0].Length;
            var sortColumnCount = 0;

            for (var c = 0; c < colCount; c++)
            {
                var temp = 1;

                for (var r = 0; r < rowCount - 1; r++)
                {
                    if (A[r][c] > A[r + 1][c])
                    {
                        temp = 0;
                        break;
                    }
                }

                sortColumnCount += temp;
            }

            return colCount - sortColumnCount;
        }
    }
}
