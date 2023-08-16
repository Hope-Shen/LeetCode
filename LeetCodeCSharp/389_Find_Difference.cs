using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Find_Difference
{
    /*
    389_Find the Difference
    2021/09/29
     
    You are given two strings s and t.
    String t is generated by random shuffling string s and then add one more letter at a random positio
    Return the letter that was added to t.

    Example 1:
    Input: s = "abcd", t = "abcde"
    Output: "e"
    Explanation: 'e' is the letter that was added.
    
    Example 2:
    Input: s = "", t = "y"
    Output: "y"
    
    Example 3:
    Input: s = "a", t = "aa"
    Output: "a"
    
    Example 4:
    Input: s = "ae", t = "aea"
    Output: "a"
    */

    public class Find_Difference
    {
        // Time complexity: O(n)
        // Space complexity: O(n)
        public static char FindTheDifference_1(string s, string t)
        {
            char result = t[0];
            if (s.Length == 0) return result;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char s_idx in s)
            {
                if (dic.ContainsKey(s_idx))
                {
                    dic[s_idx]++;
                }
                else
                {
                    dic[s_idx] = 1;
                }
            }

            foreach (char t_idx in t)
            {
                if (dic.ContainsKey(t_idx) && dic[t_idx] > 0)
                {
                    dic[t_idx]--;
                }
                else
                {
                    return t_idx;
                }
            }
            return result;
        }

        // Sum of char
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static char FindTheDifference_2(string s, string t)
        {
            int s_count = 0, t_count = 0;
            foreach (char s_idx in s)
            {
                s_count += s_idx;
            }
            foreach (char t_idx in t)
            {
                t_count += t_idx;
            }

            return (char)(t_count - s_count);
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Find the Difference_1-----");
            Console.WriteLine(FindTheDifference_1("abcd", "abcde"));
            Console.WriteLine(FindTheDifference_1("", "y"));
            Console.WriteLine(FindTheDifference_1("a", "aa"));
            Console.WriteLine(FindTheDifference_1("ae", "aea"));
            Console.WriteLine(FindTheDifference_1("abd", "abcd"));

            Console.WriteLine("-----Find the Difference_2-----");
            Console.WriteLine(FindTheDifference_2("abcd", "abcde"));
            Console.WriteLine(FindTheDifference_2("", "y"));
            Console.WriteLine(FindTheDifference_2("a", "aa"));
            Console.WriteLine(FindTheDifference_2("ae", "aea"));
            Console.WriteLine(FindTheDifference_2("abd", "abcd"));
        }
    }
}