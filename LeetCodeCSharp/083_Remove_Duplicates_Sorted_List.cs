using System;

namespace LeetCodeCSharp_Remove_Duplicates_Sorted_List
{
    /*
    083_Remove_Duplicates_Sorted_List
    2021/08/16

    Given the head of a sorted linked list, delete all duplicates such that each element appears only once. 
    Return the linked list sorted as well.

    Example 1:
    Input: head = [1,1,2]
    Output: [1,2]
    
    Example 2:
    Input: head = [1,1,2,3,3]
    Output: [1,2,3]
    */

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Remove_Duplicates_Sorted_List
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;

            ListNode curr = head;
            while (curr.next != null)
            {
                if (curr.val == curr.next.val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }

            return head;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Remove Duplicates Sorted List-----");
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(1);
            l1.next.next = new ListNode(1);
            l1.next.next.next = new ListNode(4);
            l1.next.next.next.next = new ListNode(5);
            ListNode resultList = DeleteDuplicates(l1);

            // ListNode l2 = new ListNode(1);
            // l2.next = new ListNode(3);
            // l2.next.next = new ListNode(4);
            // ListNode resultList = ReverseList(l2);

            while (resultList != null)
            {
                Console.Write(resultList.val);
                resultList = resultList.next;
            }
        }
    }
}