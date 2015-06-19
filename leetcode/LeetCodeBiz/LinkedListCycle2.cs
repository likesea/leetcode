using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class LinkedListCycle2
    {
        public ListNode DetectCycle(ListNode head)
        {
            //为空的时候
            if (head == null) return null;
            //只有一个元素的时候
            if (head.next == null) return null;
            var slow = head;
            var fast = head;
            while (slow != null)
            {
                slow = slow.next;
                if (fast != null && fast.next != null)
                {
                    fast = fast.next.next;
                }
                else
                {
                    break;
                }
                if (slow == fast)
                {
                    break;
                }
            }
            if (fast == null || fast.next == null) return null;
            var third = head;
            while (third != slow)
            {
                third = third.next;
                slow = slow.next;
            }

            return third;
        }
    }
}
