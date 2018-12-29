using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Sort_Array_By_Parity
    {
        public Sort_Array_By_Parity()
        {
            var a = SortArrayByParity(new int[]{3, 1, 2, 4});
        }

        public int[] SortArrayByParity(int[] A)
        {
            if (A.Length > 5000)
            {
                return null;
            }

            var result = new int[A.Length];
            var headIndex = 0;
            var tailIndex = A.Length - 1;

            for(int i = 0; i < A.Length; i++)
            {
                var isOdd = A[i] % 2 == 1;

                if (isOdd)
                {
                    result[tailIndex] = A[i];
                    tailIndex--;
                }
                else
                {
                    result[headIndex] = A[i];
                    headIndex++;
                }
            }

            return result;
        }
    }
}
