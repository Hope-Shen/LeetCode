using System;

namespace LeetCodeCSharp_Reverse_Linked_List
{
    /*
    206_Reverse_Linked_List
    2021/08/08

    Given the head of a singly linked list, reverse the list, and return the reversed list.
    Example 1:
    Input: head = [1,2,3,4,5]
    Output: [5,4,3,2,1]

    Example 2:
    Input: head = [1,2]
    Output: [2,1]

    Example 3:
    Input: head = []
    Output: []
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
    public class Reverse_Linked_List
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode result = null;
            ListNode curr = head;

            while (curr != null) 
            {
                ListNode next = curr.next;
                curr.next = result;
                result = curr;
                curr = next;
            }
            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Reverse Linked List-----");
            // ListNode l1 = new ListNode(1);
            // l1.next = new ListNode(2);
            // l1.next.next = new ListNode(3);
            // l1.next.next.next = new ListNode(4);
            // l1.next.next.next.next = new ListNode(5);
            // ListNode resultList = ReverseList(l1);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);
            ListNode resultList = ReverseList(l2);

            while (resultList != null)
            {
                Console.Write(resultList.val);
                resultList = resultList.next;
            }
        }
    }
}