using System;

namespace LeetCodeCSharp_Two_Sum_sorted
{
    /*
    167_Two Sum_II - Input array is sorted
    2021/09/07
    
    Given an array of integers numbers that is already sorted in non-decreasing order, 
    find two numbers such that they add up to a specific target number.

    Return the indices of the two numbers (1-indexed) as an integer array answer of size 2, 
    where 1 <= answer[0] < answer[1] <= numbers.length.

    The tests are generated such that there is exactly one solution. 
    You may not use the same element twice.

    Example 1:
    Input: numbers = [2,7,11,15], target = 9
    Output: [1,2]
    Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
    
    Example 2:
    Input: numbers = [2,3,4], target = 6
    Output: [1,3]
    
    Example 3:
    Input: numbers = [-1,0], target = -1
    Output: [1,2]
    */

    class Two_Sum
    {
        // Two pointer
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            int slow = 0;
            int fast = numbers.Length - 1;

            while (slow < fast)
            {
                if (numbers[slow] + numbers[fast] > target)
                {
                    fast--;
                }
                else if (numbers[slow] + numbers[fast] < target)
                {
                    slow++;
                }
                else
                {
                    return new int[] { slow + 1, fast + 1 };
                }
            }
            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Two Sum Sorted-----");
            Console.WriteLine(string.Join(", ", TwoSum(new int[] { 2, 7, 11, 15 }, 9)));
            Console.WriteLine(string.Join(", ", TwoSum(new int[] { 2, 3, 4 }, 6)));
            Console.WriteLine(string.Join(", ", TwoSum(new int[] { -1, 0 }, -1)));
        }
    }
}
