using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{

  
 
    public class SortListSolution
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode tail = head;
      
            while (tail.next!=null)
            {
                tail = tail.next;
            }
            return mergeSort(head, tail);
        }

        private ListNode mergeSort(ListNode begin, ListNode end)
        {
            if (begin == end) return begin;
            var mid = GetMid(begin);
            var midNext = mid.next;
            mid.next = null;
            ListNode pre = mergeSort(begin, mid);
            ListNode post = mergeSort(midNext, end);
            return mergeList(pre, post);
        }

        private ListNode mergeList(ListNode pre, ListNode post)
        {
            ListNode head=new ListNode(0);
            var temp = head;
            while (pre != null && post != null)
            {
                if (pre.val >= post.val)
                {
                    temp.next = pre;
                    temp = temp.next;
                    pre = pre.next;
                }
                else
                {
                    temp.next = post;
                    temp = temp.next;
                    post = post.next;
                }
            }
            if (pre == null)
            {
                temp.next = post;
            }
            else
            {
                temp.next = pre;
            }
            return head.next;
        }
        private ListNode GetMid(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (true)
            {
                if (fast != null && fast.next != null&&fast.next.next!=null)
                {
                    fast = fast.next.next;
                    slow = slow.next;
                }
                else
                {
                    break;
                }
            }
            return slow;
        } 
    }
}
