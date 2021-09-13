using System;
using System.Text;

namespace LeetCodeCSharp_Substring_StartEnd_1
{
    /*
    O07_Substring_StartEnd_1
    2021/09/12
    
    Given a binary string, count number of substrings that start and end with 1. 

    For example, if the input string is “00100101”, 
    then there are three substrings “1001”, “100101” and “101”.
    Source: https://www.geeksforgeeks.org/given-binary-string-count-number-substrings-start-end-1/
    */

    public class Substring_StartEnd_1
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static int countSubStr(string str)
        {
            /* if 1's counts = 1 -> 0
                           = 2 -> 1
                           = 3 -> 3
                           = 4 -> 6
                => assume 1's counts is m, then then the result should be m*(m-1)/2
            */
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result = str[i] == '1' ? result + 1 : result;
            }
            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Substring StartEnd 1-----");
            Console.WriteLine(countSubStr("00100101")); // 3
            Console.WriteLine(countSubStr("0010010101")); // 4
            Console.WriteLine(countSubStr("001001")); // 2
            Console.WriteLine(countSubStr("001")); // 1
            Console.WriteLine(countSubStr("00")); // 0
            Console.WriteLine(countSubStr("11")); // 2
            Console.WriteLine(countSubStr("1")); // 1
            Console.WriteLine(countSubStr("")); // 0
        }
    }
}