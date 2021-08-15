using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Ransom_Note
{
    /*
    383_Ransom_Note
    2021/08/15

    Given two stings ransomNote and magazine, return true if ransomNote can be constructed from magazine and false otherwise.
    Each letter in magazine can only be used once in ransomNote.

    Example 1:
    Input: ransomNote = "a", magazine = "b"
    Output: false
    
    Example 2:
    Input: ransomNote = "aa", magazine = "ab"
    Output: false
    
    Example 3:
    Input: ransomNote = "aa", magazine = "aab"
    Output: true
    */
    public class Ransom_Note
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote == "" || magazine == "") return false;

            List<char> ls = new List<char>();
            foreach (var c in ransomNote)
            {
                ls.Add(c);
            }
            // Console.WriteLine(string.Join(",", ls));

            int start = 0;
            while (ls.Count != 0 && start < magazine.Length)
            {
                if (ls.Contains(magazine[start]))
                {
                    ls.RemoveAt(ls.IndexOf(magazine[start]));
                }
                start++;
            }

            return ls.Count == 0 ? true : false;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Ransom Note-----");
            Console.WriteLine(CanConstruct("a", "b"));
            Console.WriteLine(CanConstruct("aa", "ab"));
            Console.WriteLine(CanConstruct("aa", "aab"));
            Console.WriteLine(CanConstruct("aab", "baa"));
            Console.WriteLine(CanConstruct("dee", "abcdeef"));
            Console.WriteLine(CanConstruct("", "abcdeef"));
            Console.WriteLine(CanConstruct("a", ""));
        }
    }
}