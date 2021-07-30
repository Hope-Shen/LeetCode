using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCodeCSharp_Merge_Sorted_Array
{
    /*
    088_Merge_Sorted_Array
    2021/07/30
    
    You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, 
    and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
    Merge nums1 and nums2 into a single array sorted in non-decreasing order.
    The final sorted array should not be returned by the function, 
    but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, 
    where the first m elements denote the elements that should be merged, 
    and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

    Example 1:
    Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
    Output: [1,2,2,3,5,6]
    Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
    The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
    
    Example 2:
    Input: nums1 = [1], m = 1, nums2 = [], n = 0
    Output: [1]
    Explanation: The arrays we are merging are [1] and [].
    The result of the merge is [1].
    
    Example 3:
    Input: nums1 = [0], m = 0, nums2 = [1], n = 1
    Output: [1]
    Explanation: The arrays we are merging are [] and [1].
    The result of the merge is [1].
    Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
    */

    class Merge_Sorted_Array
    {
        // Time complexity: O((n+m)log(m+n)) -> b/c Array.Sort() is O(nlogn) 
        // Space complexity: O(log(m+n)) -> b/c rray.Sort() is O(logn). 
        public static void MergeSortedArray_1(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
        }

        // Time complexity: O(m+n) -> b/c Array.Copy() is O(m) and whileloop is O(m+n)
        // Space complexity: O(m) -> b/c Array.Copy() is O(m) 
        public static void MergeSortedArray_2(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = 0;
            int p2 = 0;
            int[] sorted = new int[m];
            Array.Copy(nums1, sorted, m);
            int sorted_idx = 0;

            while (p1 < m || p2 < n)
            {
                if (p1 == m)
                {
                    nums1[sorted_idx] = nums2[p2];
                    p2++;
                }
                else if (p2 == n)
                {
                    nums1[sorted_idx] = sorted[p1];
                    p1++;
                }
                else if (sorted[p1] < nums2[p2])
                {
                    nums1[sorted_idx] = sorted[p1];
                    p1++;
                }
                else
                {
                    nums1[sorted_idx] = nums2[p2];
                    p2++;
                }
                sorted_idx += 1;
            }
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Merge Sorted Array_1-----");
            int[] nums1_1_1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] nums1_1_2 = new int[] { 2, 5, 6 };
            MergeSortedArray_1(nums1_1_1, 3, nums1_1_2, 3);
            Console.WriteLine(string.Join(", ", nums1_1_1));

            int[] nums1_2_1 = new int[] { 1 };
            int[] nums1_2_2 = new int[] { };
            MergeSortedArray_1(nums1_2_1, 1, nums1_2_2, 0);
            Console.WriteLine(string.Join(", ", nums1_2_1));

            int[] nums1_3_1 = new int[] { 4, 5, 6, 0, 0, 0 };
            int[] nums1_3_2 = new int[] { 1, 2, 3 };
            MergeSortedArray_1(nums1_3_1, 3, nums1_3_2, 3);
            Console.WriteLine(string.Join(", ", nums1_3_1));

            int[] nums1_4_1 = new int[] { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
            int[] nums1_4_2 = new int[] { 1, 2, 2 };
            MergeSortedArray_1(nums1_4_1, 6, nums1_4_2, 3);
            Console.WriteLine(string.Join(", ", nums1_4_1));

            Console.WriteLine("-----Merge Sorted Array_2-----");
            int[] nums2_1_1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] nums2_1_2 = new int[] { 2, 5, 6 };
            MergeSortedArray_2(nums2_1_1, 3, nums2_1_2, 3);
            Console.WriteLine(string.Join(", ", nums2_1_1));

            int[] nums2_2_1 = new int[] { 1 };
            int[] nums2_2_2 = new int[] { };
            MergeSortedArray_2(nums2_2_1, 1, nums2_2_2, 0);
            Console.WriteLine(string.Join(", ", nums2_2_1));

            int[] nums2_3_1 = new int[] { 4, 5, 6, 0, 0, 0 };
            int[] nums2_3_2 = new int[] { 1, 2, 3 };
            MergeSortedArray_2(nums2_3_1, 3, nums2_3_2, 3);
            Console.WriteLine(string.Join(", ", nums2_3_1));

            int[] nums2_4_1 = new int[] { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
            int[] nums2_4_2 = new int[] { 1, 2, 2 };
            MergeSortedArray_2(nums2_4_1, 6, nums2_4_2, 3);
            Console.WriteLine(string.Join(", ", nums2_4_1));
        }
    }
}
