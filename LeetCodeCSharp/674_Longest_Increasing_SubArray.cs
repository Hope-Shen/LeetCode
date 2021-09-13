using System;

namespace LeetCodeCSharp_Longest_Increasing_SubArray
{
    /*
    674_Longest Continuous Increasing Subsequence
    2021/09/13

    Given an unsorted array of integers nums, return the length of the longest continuous increasing subsequence (i.e. subarray). 
    The subsequence must be strictly increasing.

    A continuous increasing subsequence is defined by two indices l and r (l < r) such that it is [nums[l], 
    nums[l + 1], ..., nums[r - 1], nums[r]] and for each l <= i < r, nums[i] < nums[i + 1].

    Example 1:
    Input: nums = [1,3,5,4,7]
    Output: 3
    Explanation: The longest continuous increasing subsequence is [1,3,5] with length 3.
    Even though [1,3,5,7] is an increasing subsequence, it is not continuous as elements 5 and 7 are separated by element 4.
    
    Example 2:
    Input: nums = [2,2,2,2,2]
    Output: 1
    Explanation: The longest continuous increasing subsequence is [2] with length 1. Note that it must be strictly increasing.
    */

    public class Longest_Increasing_SubArray
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static int FindLengthOfLCIS(int[] nums)
        {
            int result = 1;
            int newPoint = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] <= 0)
                {
                    newPoint = i;
                }
                result = Math.Max(result, i - newPoint + 1);
            }
            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Move Zeroes-----");
            Console.WriteLine(FindLengthOfLCIS(new int[] { 1, 3, 5, 4, 7 }));
            Console.WriteLine(FindLengthOfLCIS(new int[] { 2,2,2,2,2 }));
            Console.WriteLine(FindLengthOfLCIS(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(FindLengthOfLCIS(new int[] { 5, 4, 3, 4, 5 }));
            Console.WriteLine(FindLengthOfLCIS(new int[] { 1 }));
        }
    }
}