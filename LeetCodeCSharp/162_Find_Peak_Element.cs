using System;

namespace LeetCodeCSharp_Find_Peak_Element
{
    /*
    162_Find Peak Element
    2021/09/13
    
    A peak element is an element that is strictly greater than its neighbors.
    Given an integer array nums, find a peak element, and return its index. 
    If the array contains multiple peaks, return the index to any of the peaks.
    You may imagine that nums[-1] = nums[n] = -∞.
    You must write an algorithm that runs in O(log n) time.

    Example 1:
    Input: nums = [1,2,3,1]
    Output: 2
    Explanation: 3 is a peak element and your function should return the index number 2.
    
    Example 2:
    Input: nums = [1,2,1,3,5,6,4]
    Output: 5
    Explanation: Your function can return either index number 1 where the peak element is 2, or index number 5 where the peak element is 6.
    */
    public class Find_Peak_Element
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static int FindPeakElement_1(int[] nums)
        {
            int result = 0;
            if (nums.Length == 1) return result;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] < 0)
                {
                    return i - 1;
                }
                result = i;
            }
            return result;
        }

        // Binary Search
        // Time complexity: O(log n)
        // Space complexity: O(1)
        public static int FindPeakElement_2(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Find Peak Element_1-----");
            Console.WriteLine(FindPeakElement_1(new int[] { 1, 2, 3, 1 }));
            Console.WriteLine(FindPeakElement_1(new int[] { 1, 2, 1, 3, 5, 6, 4 }));
            Console.WriteLine(FindPeakElement_1(new int[] { 2, 1, 2 }));
            Console.WriteLine(FindPeakElement_1(new int[] { 1, 2 }));
            Console.WriteLine(FindPeakElement_1(new int[] { 1 }));

            Console.WriteLine("-----Find Peak Element_2-----");
            Console.WriteLine(FindPeakElement_2(new int[] { 1, 2, 3, 1 }));
            Console.WriteLine(FindPeakElement_2(new int[] { 1, 2, 1, 3, 5, 6, 4 }));
            Console.WriteLine(FindPeakElement_2(new int[] { 2, 1, 2 }));
            Console.WriteLine(FindPeakElement_2(new int[] { 1, 2 }));
            Console.WriteLine(FindPeakElement_2(new int[] { 1 }));
        }
    }
}