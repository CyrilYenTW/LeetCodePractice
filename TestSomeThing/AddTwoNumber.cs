using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class AddTwoNumber
    {
        public AddTwoNumber()
        {
            var l1 = new ListNode(5);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);

            var l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            var a = new Solution().AddTwoNumbers(l1, l2);
        }

        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                if (l1 == null && l2 == null)
                {
                    return null;
                }

                var sumValue = ((l1 == null) ? 0 : l1.val) + ((l2 == null) ? 0 : l2.val);

                ListNode result = new ListNode(sumValue % 10);

                l1 = (l1 == null || l1.next == null) ? null : l1.next;
                l2 = (l2 == null || l2.next == null) ? null : l2.next;

                var isCarry = (sumValue / 10) > 0;

                if (l1 == null && isCarry)
                {
                    l1 = new ListNode(1);
                }
                else if (isCarry)
                {
                    l1.val += 1;
                }

                result.next = AddTwoNumbers(l1, l2);

                return result;
            }
        }

        public class ListNode
        {
            public int val;

            public ListNode next;

            public ListNode(int x)
            {
                this.val = x;
            }
        }
    }
}
