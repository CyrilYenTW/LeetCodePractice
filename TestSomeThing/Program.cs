using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    class Program
    {
        static int Result = 0;

        static void Main(string[] args)
        {
            new UnitTest();
        }

        static void Test()
        {
            var originString = "00000000";

            var nextString = string.Empty;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 9999999; i++)
            {
                originString = GetNextValue(originString);
            }

            watch.Stop();

            var getTime = watch.ElapsedMilliseconds;

            watch.Reset();
            watch.Start();

            originString = "00000000";

            for (int i = 0; i < 9999999; i++)
            {
                originString = GetNextValue2(originString);
            }

            watch.Stop();

            getTime = watch.ElapsedMilliseconds;
        }


        static string GetNextValue2(string noValue)
        {
            var digits = noValue.Length;
            var zeroString = string.Empty;

            for (int i = 0; i < digits; i++)
            {
                zeroString += "0";
            }

            var temp = Convert.ToUInt32(noValue);

            return temp++.ToString(zeroString);
        }

        static string GetNextValue(string nowValue)
        {
            var digit_36_entities = new char[36] { '0', '1', '2', '3', '4', '5', '6', '7', '8',
                                                   '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
                                                   'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q',
                                                   'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

            var digit_34_entities = new char[34] { '0', '1', '2', '3', '4', '5', '6', '7', '8',
                                                   '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
                                                   'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S',
                                                   'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

            var digit_10_entities = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };


            var nowValueArrary = nowValue.ToArray();

            char[] digitEntity = digit_10_entities;

            // 最後一位數
            var lastCharIndex = nowValueArrary.Length - 1;

            var addTag = true;

            while (addTag == true && lastCharIndex > -1)
            {
                var lastChar = nowValueArrary[lastCharIndex];

                var lastCharDigitEntityIndex = Array.FindIndex(digitEntity, m => m == lastChar);

                if (lastCharDigitEntityIndex == digitEntity.Length - 1)
                {
                    nowValueArrary[lastCharIndex] = digitEntity[0];
                    lastCharIndex--;
                }
                else
                {
                    nowValueArrary[lastCharIndex] = digitEntity[lastCharDigitEntityIndex + 1];
                    addTag = false;
                }
            }

            var result = new string(nowValueArrary);

            return result;
        }
    }
}
