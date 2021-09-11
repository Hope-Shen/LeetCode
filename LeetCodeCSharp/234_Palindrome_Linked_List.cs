using System;

namespace LeetCodeCSharp_Palindrome_Linked_List
{
    /*
    234_Palindrome_Linked_List
    2021/09/08

    Given the head of a singly linked list, return true if it is a palindrome.

    Example 1:
    Input: head = [1,2,2,1]
    Output: true
    
    Example 2:
    Input: head = [1,2]
    Output: false
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
    public class Palindrome_Linked_List
    {
        // Two pointer
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null)
            {
                return true;
            }
            ListNode fast = head;
            ListNode slow = head;

            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            ListNode leftNode = head;
            ListNode rightNode = ReverseLinked(slow.next);

            while (leftNode != null && rightNode != null)
            {
                if (leftNode.val != rightNode.val)
                {
                    return false;
                }
                leftNode = leftNode.next;
                rightNode = rightNode.next;
            }

            return true;
        }

        private static ListNode ReverseLinked(ListNode node)
        {
            ListNode result = null;
            while (node != null)
            {
                ListNode next = node.next;
                node.next = result;
                result = node;
                node = next;
            }
            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Palindrome Linked List-----");
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(2);
            l1.next.next.next = new ListNode(1);
            Console.WriteLine(IsPalindrome(l1));

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(2);
            Console.WriteLine(IsPalindrome(l2));

            ListNode l3 = new ListNode(1);
            Console.WriteLine(IsPalindrome(l3));
        }
    }
}