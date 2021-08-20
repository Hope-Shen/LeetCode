using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Binary_Search
{
    /*
    704_Binary_Search
    2021/08/15

    Given an array of integers nums which is sorted in ascending order, and an integer target, 
    write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

    You must write an algorithm with O(log n) runtime complexity.

    Example 1:
    Input: nums = [-1,0,3,5,9,12], target = 9
    Output: 4
    Explanation: 9 exists in nums and its index is 4
    
    Example 2:
    Input: nums = [-1,0,3,5,9,12], target = 2
    Output: -1
    Explanation: 2 does not exist in nums so return -1
    */
    public class Binary_Search
    {
        // Time complexity: O(log n)
        // Space complexity: O(1)
        public static int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                // go left
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                //go right
                else
                {
                    start = mid + 1;
                }
            }

            return -1;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----FizzBuzz_1-----");
            Console.WriteLine(Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
            Console.WriteLine(Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
            Console.WriteLine(Search(new int[] { 5 }, 5));
            Console.WriteLine(Search(new int[] { }, 5));
        }
    }
}