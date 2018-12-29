using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Median_of_Two_Sorted_Arrays
    {
        public Median_of_Two_Sorted_Arrays()
        {
            var a = FindMedianSortedArrays(new int[]{1, 2}, new int[]{3, 4});
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var n1Length = nums1.Length;
            var n2Length = nums2.Length;
            var n1Index = n1Length - 1;
            var n2Index = n2Length - 1;

            var sortDic = new Dictionary<int, int>();
            var dicIndex = -1;

            while (n1Index > -1 || n2Index > -1)
            {
                dicIndex++;

                var num1 = n1Index <= -1 ? int.MinValue : nums1[n1Index];
                var num2 = n2Index <= -1 ? int.MinValue : nums2[n2Index];

                if (num1 > num2)
                {
                    sortDic[dicIndex] = num1;
                    n1Index--;
                }
                else if (num1 == num2)
                {
                    sortDic[dicIndex] = num1;
                    n1Index--;
                    dicIndex++;
                    sortDic[dicIndex] = num2;
                    n2Index--;
                }
                else
                {
                    sortDic[dicIndex] = num2;
                    n2Index--;
                }
               
            }
            
            var isOdd = dicIndex % 2 == 0;
            var medianIndex = dicIndex / 2;

            return isOdd ? sortDic[medianIndex] : (sortDic[medianIndex] + sortDic[medianIndex + 1]) / (double) 2;
        }
    }
}
