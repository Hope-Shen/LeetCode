using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Longest_Palindrome
{
    /*
    409_Longest_Palindrome
    2021/08/14

    Given a string s which consists of lowercase or uppercase letters, 
    return the length of the longest palindrome that can be built with those letters.
    Letters are case sensitive, for example, "Aa" is not considered a palindrome here.

    Example 1:
    Input: s = "abccccdd"
    Output: 7
    Explanation:
    One longest palindrome that can be built is "dccaccd", whose length is 7.
    
    Example 2:
    Input: s = "a"
    Output: 1
    
    Example 3:
    Input: s = "bb"
    Output: 2
    */
    public class Longest_Palindrome
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static int LongestPalindrome_1(string s)
        {
            int result = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (!dic.ContainsKey(c))
                {
                    dic[c] = 1;
                }
                else
                {
                    dic[c]++;
                }
            }

            int odd = 0;
            foreach (var c in dic.Keys)
            {
                if (odd == 0) odd = dic[c] % 2;
                result += dic[c] / 2 * 2;
            }

            return result + odd;
        }

        // Time complexity: O(n)
        // Space complexity: O(1)
        public static int LongestPalindrome_2(string s)
        {
            int result = 0;
            HashSet<int> hash = new HashSet<int>();
            foreach (var c in s)
            {
                if (hash.Contains(c))
                {
                    hash.Remove(c);
                    result++;
                }
                else
                {
                    hash.Add(c);
                }
            }

            return hash.Count > 0 ? result * 2 + 1 : result * 2;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Longest Palindrome_1-----");
            Console.WriteLine(LongestPalindrome_1("abccccdd"));
            Console.WriteLine(LongestPalindrome_1("a"));
            Console.WriteLine(LongestPalindrome_1("bb"));
            Console.WriteLine(LongestPalindrome_1("ccc"));
            Console.WriteLine(LongestPalindrome_1("abcccdd"));

            Console.WriteLine("-----Longest Palindrome_2-----");
            Console.WriteLine(LongestPalindrome_2("abccccdd"));
            Console.WriteLine(LongestPalindrome_2("a"));
            Console.WriteLine(LongestPalindrome_2("bb"));
            Console.WriteLine(LongestPalindrome_2("ccc"));
            Console.WriteLine(LongestPalindrome_2("abcccdd"));
        }
    }
}