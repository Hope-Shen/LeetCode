using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Two_Sum
{
    /*
    001_Two_Sum
    2021/07/30
    
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.
     
    Example 1:
    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Output: Because nums[0] + nums[1] == 9, we return [0, 1].
    
    Example 2:
    Input: nums = [3,2,4], target = 6
    Output: [1,2]
    
    Example 3:
    Input: nums = [3,3], target = 6
    Output: [0,1]
    */

    class Two_Sum
    {
        // Time complexity: O(n^2)
        // Space complexity: O(1)
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] arr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        arr[0] = i;
                        arr[1] = j;
                        break;
                    }
                }
            }
            return arr;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Two Sum-----");
            Console.WriteLine(string.Join(", ", TwoSum(new int[] { 2, 7, 11, 15 }, 9)));
            Console.WriteLine(string.Join(", ", TwoSum(new int[] { 3, 2, 4 }, 6)));
            Console.WriteLine(string.Join(", ", TwoSum(new int[] { 3, 3 }, 6)));
        }
    }
}
