using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_K_diff_Pairs_in_Array
{
    /*
    532_K-diff Pairs in an Array
    2021/09/29
    
    Given an array of integers nums and an integer k, return the number of unique k-diff pairs in the array.
    
    A k-diff pair is an integer pair (nums[i], nums[j]), where the following are true:
    - 0 <= i < j < nums.length
    - |nums[i] - nums[j]| == k
    
    Notice that |val| denotes the absolute value of val.

    Example 1:
    Input: nums = [3,1,4,1,5], k = 2
    Output: 2
    Explanation: There are two 2-diff pairs in the array, (1, 3) and (3, 5).
    Although we have two 1s in the input, we should only return the number of unique pairs.
    
    Example 2:
    Input: nums = [1,2,3,4,5], k = 1
    Output: 4
    Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and (4, 5).
    
    Example 3:
    Input: nums = [1,3,1,5,4], k = 0
    Output: 1
    Explanation: There is one 0-diff pair in the array, (1, 1).
    
    Example 4:
    Input: nums = [1,2,4,4,3,3,0,9,2,3], k = 3
    Output: 2
    
    Example 5:
    Input: nums = [-1,-2,-3], k = 1
    Output: 2
    */

    public class K_diff_Pairs_in_Array
    {
        // Time complexity: O(n)
        // Space complexity: O(n)
        public static int FindPairs(int[] nums, int k)
        {
            if (k < 0) return 0;

            int result = 0;
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();

            foreach (int i in nums)
            {
                if (!dic.ContainsKey(i))
                {
                    dic[i] = 1;
                }
                else
                {
                    dic[i]++;
                }
            }

            if (k == 0)
            {
                foreach (int n in dic.Keys)
                {
                    if (dic[n] > 1)
                    {
                        result++;
                    }
                }
            }
            else
            {
                foreach (int n in dic.Keys)
                {
                    if (dic.ContainsKey(n + k))
                    {
                        result++;
                    }
                }
            }
            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----K-diff Pairs in an Array-----");
            Console.WriteLine(FindPairs(new int[] { 3, 1, 4, 1, 5 }, 2));
            Console.WriteLine(FindPairs(new int[] { 1, 2, 3, 4, 5 }, 1));
            Console.WriteLine(FindPairs(new int[] { 1, 3, 1, 5, 4 }, 0));
            Console.WriteLine(FindPairs(new int[] { 1, 2, 4, 4, 3, 3, 0, 9, 2, 3 }, 3));
            Console.WriteLine(FindPairs(new int[] { -1, -2, -3 }, 1));
        }
    }
}