using System;

namespace LeetCodeCSharp_Max_SubArray
{
    /*
    053_Max_SubArray
    2021/07/29

    Given an integer array nums, find the contiguous subarray (containing at least one number) 
    which has the largest sum and return its sum.
    A subarray is a contiguous part of an array.

    Example 1:
    Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
    Output: 6
    Explanation: [4,-1,2,1] has the largest sum = 6.

    Example 2:
    Input: nums = [1]
    Output: 1

    Example 3:
    Input: nums = [5,4,-1,7,8]
    Output: 23
    */

    public class Max_SubArray
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static int MaxSubArray(int[] nums)
        {
            int max = nums[0], pre_sum = 0, sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = pre_sum + nums[i];
                pre_sum = sum > 0 ? sum : 0;
                max = Math.Max(max, sum);
            }
            return max;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Max SubArray-----");
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(MaxSubArray(arr));

            int[] arr_2 = { 1 };
            Console.WriteLine(MaxSubArray(arr_2));

            int[] arr_3 = { 5, 4, -1, 7, 8 };
            Console.WriteLine(MaxSubArray(arr_3));

            int[] arr_4 = { -1 };
            Console.WriteLine(MaxSubArray(arr_4));
        }
    }
}