using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Largest_Odd_String
{
    /*
    1903_Largest Odd Number in String
    2021/09/12

    You are given a string num, representing a large integer. 
    Return the largest-valued odd integer (as a string) that is a non-empty substring of num, or an empty string "" if no odd integer exists.
    
    A substring is a contiguous sequence of characters within a string.

    Example 1:
    Input: num = "52"
    Output: "5"
    Explanation: The only non-empty substrings are "5", "2", and "52". "5" is the only odd number.
    
    Example 2:
    Input: num = "4206"
    Output: ""
    Explanation: There are no odd numbers in "4206".
    
    Example 3:
    Input: num = "35427"
    Output: "35427"
    Explanation: "35427" is already an odd number.
    */
    public class Largest_Odd_String
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static string LargestOddNumber(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] % 2 == 1)
                {
                    return num.Substring(0, i + 1);
                }
            }
            return "";
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Ransom Note-----");
            Console.WriteLine(LargestOddNumber("52"));
            Console.WriteLine(LargestOddNumber("4206"));
            Console.WriteLine(LargestOddNumber("35427"));
            Console.WriteLine(LargestOddNumber("5"));
            Console.WriteLine(LargestOddNumber("2"));
            Console.WriteLine(LargestOddNumber("7542351161"));
        }
    }
}