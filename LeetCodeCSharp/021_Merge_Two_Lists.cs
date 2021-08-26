using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Merge_Two_Lists
{
    /*
    021_Merge_Two_Lists
    2021/06/10
    Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.
    Example 1:
    Input: l1 = [1,2,4], l2 = [1,3,4]
    Output: [1,1,2,3,4,4]

    Example 2:
    Input: l1 = [], l2 = []
    Output: []

    Example 3:
    Input: l1 = [], l2 = [0]
    Output: [0]

    Constraints:
    The number of nodes in both lists is in the range [0, 50].
    -100 <= Node.val <= 100
    Both l1 and l2 are sorted in non-decreasing order.
    */

    class Merge_Two_Lists
    {
        // Time complexity: O(n+m)
        // Space complexity: O(n+m)
        public static ListNode MergeTwoLists_1(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists_1(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists_1(l2.next, l1);
                return l2;
            }
        }

        // Time complexity: O(n+m)
        // Space complexity: O(1)
        public static ListNode MergeTwoLists_2(ListNode l1, ListNode l2)
        {
            ListNode resultList = new ListNode(0);
            ListNode current = resultList;
            // while 判斷 l1 及 l2 是否還有值
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }
            current.next = l1 != null ? l1 : l2;
            return resultList.next;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            // ListNode resultList_1 = MergeTwoLists_1(l1, l2);
            // while (resultList_1 != null)
            // {
            //     Console.Write(resultList_1.val);
            //     resultList_1 = resultList_1.next;
            // }

            ListNode resultList_2 = MergeTwoLists_2(l1, l2);
            while (resultList_2 != null)
            {
                Console.Write(resultList_2.val);
                resultList_2 = resultList_2.next;
            }
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
