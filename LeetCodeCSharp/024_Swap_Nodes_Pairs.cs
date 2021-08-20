using System;

namespace LeetCodeCSharp_Swap_Nodes_Pairs
{
    /*
    024_Swap_Nodes_Pairs
    2021/08/16

    Given a linked list, swap every two adjacent nodes and return its head. 
    You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)

    Example 1:
    Input: head = [1,2,3,4]
    Output: [2,1,4,3]
    
    Example 2:
    Input: head = []
    Output: []
    
    Example 3:
    Input: head = [1]
    Output: [1]
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
    public class Swap_Nodes_Pairs
    {
        // Iterative soluation
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static ListNode SwapPairs(ListNode head)
        {
            ListNode result = new ListNode();
            result.next = head;
            ListNode curr = result;

            while (curr.next != null && curr.next.next != null)
            {
                ListNode node1 = curr.next;
                ListNode node2 = curr.next.next;
                curr.next = node2;
                node1.next = node2.next;
                node2.next = node1;
                curr = node1;
            }

            return result.next;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Swap Nodes in Pairs-----");
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(4);
            l1.next.next.next.next = new ListNode(5);
            ListNode resultList = SwapPairs(l1);

            while (resultList != null)
            {
                Console.Write(resultList.val);
                resultList = resultList.next;
            }
        }
    }
}