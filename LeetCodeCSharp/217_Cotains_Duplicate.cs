using System;

namespace LeetCodeCSharp_Cotains_Duplicate
{
    /*
    217_Cotains_Duplicate
    2021/07/29

    Given an integer array nums, return true if any value appears at least twice in the array, 
    and return false if every element is distinct.

    Example 1:
    Input: nums = [1,2,3,1]
    Output: true

    Example 2:
    Input: nums = [1,2,3,4]
    Output: false

    Example 3:
    Input: nums = [1,1,1,3,3,4,3,2,4,2]
    Output: true
    */

    public class Cotains_Duplicate
    {
        // Time complexity: O(n log n)
        // Space complexity: O(log n)
        public static bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums); int num_len = nums.Length;
            for (int i = 1; i < num_len; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Cotains Duplicate-----");
            int[] arr = { 1, 2, 3, 1 };
            Console.WriteLine(ContainsDuplicate(arr));

            int[] arr_2 = { 1, 2, 3, 4 };
            Console.WriteLine(ContainsDuplicate(arr_2));

            int[] arr_3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(ContainsDuplicate(arr_3));
        }
    }
}