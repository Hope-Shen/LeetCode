using System;

namespace LeetCodeCSharp_Move_Zeroes
{
    /*
    283_Move_Zeroes
    2021/08/19

    Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

    Note that you must do this in-place without making a copy of the array.

    Example 1:
    Input: nums = [0,1,0,3,12]
    Output: [1,3,12,0,0]
    
    Example 2:
    Input: nums = [0]
    Output: [0]
    */

    public class Move_Zeroes
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static void MoveZeroes(int[] nums)
        {
            int left = 0;
            int right = 0;
            while (right < nums.Length)
            {
                if (nums[right] != 0)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                    left++;
                }
                right++;
            }
            Console.WriteLine(string.Join(", ", nums));
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Move Zeroes-----");
            MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
            MoveZeroes(new int[] { 0 });
            MoveZeroes(new int[] { 1, 0, 1 });
        }
    }
}