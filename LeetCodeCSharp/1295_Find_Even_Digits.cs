using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Find_Even_Digits
{
    /*
    1295_Find Numbers with Even Number of Digits
    2021/09/12

    Given an array nums of integers, return how many of them contain an even number of digits.
 
    Example 1:
    Input: nums = [12,345,2,6,7896]
    Output: 2
    Explanation: 
    12 contains 2 digits (even number of digits). 
    345 contains 3 digits (odd number of digits). 
    2 contains 1 digit (odd number of digits). 
    6 contains 1 digit (odd number of digits). 
    7896 contains 4 digits (even number of digits). 
    Therefore only 12 and 7896 contain an even number of digits.
    
    Example 2:
    Input: nums = [555,901,482,1771]
    Output: 1 
    Explanation: 
    Only 1771 contains an even number of digits.
    */
    public class Find_Even_Digits
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static int FindNumbers(int[] nums)
        {
            int result = 0;
            foreach (var i in nums)
            {
                if (i.ToString().Length % 2 == 0)
                {
                    result++;
                }
            }
            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Find Numbers with Even Number of Digits-----");
            Console.WriteLine(FindNumbers(new int[] { 12, 345, 2, 6, 7896 }));
            Console.WriteLine(FindNumbers(new int[] { 555, 901, 482, 1771 }));
            Console.WriteLine(FindNumbers(new int[] { 1 }));
            Console.WriteLine(FindNumbers(new int[] { 12 }));
            Console.WriteLine(FindNumbers(new int[] { }));
        }
    }
}