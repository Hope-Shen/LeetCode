using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Cotains_Duplicate
{
    /*
    217_Cotains_Duplicate
    2021/07/28

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
        //   -> b/c Sorting(line 32) is O(nlogn) and the sweeping is O(n). The entire algorithm is dominated by the sorting step, which is O(nlogn).
        // Space complexity: O(log n)
        //   -> b/c Sorting(line 32) is O(logn). 
        public static bool ContainsDuplicate_1(int[] nums)
        {
            Array.Sort(nums);
            int num_len = nums.Length;
            for (int i = 1; i < num_len; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

        // Time complexity: O(n)
        // Space complexity: O(n)
        public static bool ContainsDuplicate_2(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            foreach (var x in nums)
            {
                if (hs.Contains(x))
                {
                    return true;
                }
                hs.Add(x);
            }
            return false;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Cotains Duplicate_1-----");
            int[] arr = { 1, 2, 3, 1 };
            Console.WriteLine(ContainsDuplicate_1(arr));

            int[] arr_2 = { 1, 2, 3, 4 };
            Console.WriteLine(ContainsDuplicate_1(arr_2));

            int[] arr_3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(ContainsDuplicate_1(arr_3));

            Console.WriteLine("-----Cotains Duplicate_-----");
            int[] arr_4 = { 1, 2, 3, 1 };
            Console.WriteLine(ContainsDuplicate_2(arr_4));

            int[] arr_5 = { 1, 2, 3, 4 };
            Console.WriteLine(ContainsDuplicate_2(arr_5));

            int[] arr_6 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(ContainsDuplicate_2(arr_6));
        }
    }
}