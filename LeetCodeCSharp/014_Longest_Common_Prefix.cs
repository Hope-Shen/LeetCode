using System;

namespace LeetCodeCSharp_Longest_Common_Prefix
{
    /*
    014_Longest Common Prefix
    2021/09/11

    Write a function to find the longest common prefix string amongst an array of strings.

    If there is no common prefix, return an empty string "".

    Example 1:
    Input: strs = ["flower","flow","flight"]
    Output: "fl"
    
    Example 2:
    Input: strs = ["dog","racecar","car"]
    Output: ""
    Explanation: There is no common prefix among the input strings.
    */
    public class Longest_Common_Prefix
    {
        // Time complexity: O(n*m)
        // Space complexity: O(1)
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || strs[0][i] != strs[j][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Longest Common Prefix-----");
            Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
            Console.WriteLine(LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
            Console.WriteLine(LongestCommonPrefix(new string[] { "dog" }));
            Console.WriteLine(LongestCommonPrefix(new string[] { }));
            Console.WriteLine(LongestCommonPrefix(new string[] { "ab", "a" }));
        }
    }
}