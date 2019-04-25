using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{


     public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int x) { val = x; }
     }

    public class Merge_Two_Sorted_Lists
    {
        public Merge_Two_Sorted_Lists()
        {
            var test1 = new ListNode(1);
            test1.next = new ListNode(5);
            test1.next.next = new ListNode(3);

            var test2 = new ListNode(4);
            test2.next = new ListNode(2);

            var result = this.MergeTwoLists(test1, test2);
        }
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            var result = new List<int>();

            while(l1 != null)
            {
                result.Add(l1.val);
                l1 = l1.next;
            }

            while(l2 != null)
            {
                result.Add(l2.val);
                l2 = l2.next;
            }

            result = result.OrderBy(m => m).ToList();

            ListNode node = new ListNode(result.FirstOrDefault());
            ListNode header = node;            

            foreach(var temp in result.Skip(1))
            {
                node.next = new ListNode(temp);
                node = node.next;
            }

            return header;
        }
    }
}
