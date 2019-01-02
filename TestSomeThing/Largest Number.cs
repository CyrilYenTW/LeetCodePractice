using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Largest_Number
    {
        public Largest_Number()
        {
            // var input = new int[] { 3, 30, 34, 5, 9};

            // var input = new int[] { 121, 12 };

            var input = new int[] { 10, 2};

            // var input = new int[] { 999999998, 999999997, 999999999 };

            // var input = new int[] { 74, 21, 33, 51, 77, 51, 90, 60, 5, 56 };

            // var input = new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
        }

        public string LargestNumber(int[] nums)
        {
            if (nums.Max() == 0)
            {
                return "0";
            }

            var maxNumDigits = nums.Max().ToString().Length;

            var itemList = new List<Item>();

            foreach (var num in nums)
            {
                itemList.Add(new Item(num, maxNumDigits));
            }

            itemList = itemList.OrderByDescending(m => m.Value).ThenByDescending(m => m.Origin.Length).ToList();

            for (int i = itemList.Count - 1; i > 0; i--)
            {
                if (itemList[i].Value == itemList[i - 1].Value)
                {
                    if (itemList[i].Value.Length > 1 && itemList[i].Value[0] < itemList[i].Value[1])
                    {
                        var temp = itemList[i];
                        itemList[i] = itemList[i - 1];
                        itemList[i - 1] = temp;
                    }
                }
            }

            var result = itemList.Select(m => m.Origin).ToArray();

            return String.Join("", result);
        }

        class Item
        {
            public string Origin { get; }

            public string Value { get; }

            public Item(int origin, int digits)
            {
                this.Origin = origin.ToString();
                this.Value = origin.ToString();

                var index = 0;

                while (this.Value.Length < digits)
                {
                    this.Value += this.Origin[index];

                    index = index + 1 >= this.Origin.Length ? 0 : index + 1;
                }
            }
        }

        public string LargestNumberV2(int[] nums)
        {
            var strs = new List<string>(nums.Select(n => n.ToString()));
            strs.Sort((a, b) => string.Compare(b+a, a+b));
            return strs[0][0] == '0' ? "0" : string.Join("", strs);
        }
    }
}
