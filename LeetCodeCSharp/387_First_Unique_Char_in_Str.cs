using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_First_Unique_Char_in_Str
{
    /*
    387_First_Unique_Char_in_Str
    2021/08/08

    Given a string s, find the first non-repeating character in it and return its index. 
    If it does not exist, return -1.
    
    Example 1:
    Input: s = "leetcode"
    Output: 0

    Example 2:
    Input: s = "loveleetcode"
    Output: 2
    
    Example 3:
    Input: s = "aabb"
    Output: -1
    */

    public class First_Unique_Char_in_Str
    {
        // Time complexity: O(n)
        // Space complexity: O(n)
        public static int FirstUniqChar(string s)
        {
            if (s.Length == 0) return -1;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], 1);
                }
                else
                {
                    dic[s[i]]++;
                }
            }

            foreach(var x in dic)
            {
                if(x.Value == 1)
                {
                    return s.IndexOf(x.Key);
                }
            }
            return -1;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----First Unique Char in Str-----");
            Console.WriteLine(FirstUniqChar("leetcode"));
            Console.WriteLine(FirstUniqChar("loveleetcode"));
            Console.WriteLine(FirstUniqChar("aabb"));
            Console.WriteLine(FirstUniqChar("dddccdbba"));
        }
    }
}