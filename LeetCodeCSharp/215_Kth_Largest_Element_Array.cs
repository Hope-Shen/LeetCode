using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Kth_Largest_Element_Array
{
    /*
    215_Kth Largest Element in an Array
    2021/09/28

    Given an integer array nums and an integer k, return the kth largest element in the array.
    Note that it is the kth largest element in the sorted order, not the kth distinct element.

    Example 1:
    Input: nums = [3,2,1,5,6,4], k = 2
    Output: 5
    
    Example 2:
    Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
    Output: 4
    */

    public class Kth_Largest_Element_Array
    {
        // Time complexity: O(n log n)
        // Space complexity: O(1)
        public static int FindKthLargest_1(int[] nums, int k)
        {
            Array.Sort(nums);
            Array.Reverse(nums);

            return nums[k - 1];
        }

        // Quicksort
        // Time complexity: O(n) ->b/c Discard half each time: n+(n/2)+(n/4)..1 = n + (n-1) = O(2n-1) = O(n)
        // Space complexity: O(1)
        public static int FindKthLargest_2(int[] nums, int k)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            int i;
            int start = 0, end = nums.Length - 1;
            while (start <= end)
            {
                i = partition(nums, start, end);
                if (nums.Length - k == i)
                {
                    return nums[i];
                }
                else if (nums.Length - k < i)
                {
                    end = i - 1;
                }
                else
                {
                    start = i + 1;
                }
            }
            return nums[k];
        }

        public static int partition(int[] arr, int left, int right)
        {
            int l = left;
            int pivot = arr[right];
            int temp;
            for (int r = left; r < arr.Length; r++)
            {
                if (arr[r] < pivot)
                {
                    temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                    l++;
                }
            }
            temp = arr[l];
            arr[l] = arr[right];
            arr[right] = temp;
            return l;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Kth Largest Element in an Array_1-----");
            Console.WriteLine(FindKthLargest_1(new int[] { 3, 2, 1, 5, 6, 4 }, 2));
            Console.WriteLine(FindKthLargest_1(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4));
            Console.WriteLine(FindKthLargest_1(new int[] { 2, 1 }, 1));
            Console.WriteLine(FindKthLargest_1(new int[] { 1 }, 1));
            Console.WriteLine(FindKthLargest_1(new int[] { -1, 2, 0 }, 1));

            // Console.WriteLine("-----Kth Largest Element in an Array_2-----");
            Console.WriteLine(FindKthLargest_2(new int[] { 3, 2, 1, 5, 6, 4 }, 2));
            Console.WriteLine(FindKthLargest_2(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4));
            Console.WriteLine(FindKthLargest_2(new int[] { 2, 1 }, 1));
            Console.WriteLine(FindKthLargest_2(new int[] { 1 }, 1));
            Console.WriteLine(FindKthLargest_2(new int[] { -1, 2, 0 }, 1));
        }
    }
}