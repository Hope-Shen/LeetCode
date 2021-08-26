using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeCSharp_Sort_Characters_Frequency
{
    /*
    451_Sort_Characters_By_Frequency
    2021/08/20

    Given a string s, sort it in decreasing order based on the frequency of characters, and return the sorted string.

    Example 1:
    Input: s = "tree"
    Output: "eert"
    Explanation: 'e' appears twice while 'r' and 't' both appear once.
    So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
    
    Example 2:
    Input: s = "cccaaa"
    Output: "aaaccc"
    Explanation: Both 'c' and 'a' appear three times, so "aaaccc" is also a valid answer.
    Note that "cacaca" is incorrect, as the same characters must be together.
    
    Example 3:
    Input: s = "Aabb"
    Output: "bbAa"
    Explanation: "bbaA" is also a valid answer, but "Aabb" is incorrect.
    Note that 'A' and 'a' are treated as two different characters.
    */
    public class Sort_Characters_Frequency
    {
        // Time complexity: O(n + k log k + k) => O(n + k log k)
        //      first: n is the length of given s (first for loop), 
        //      second: k log k is for stort, 
        //      third: for second for loop to litrate sorted dictionary 
        // Space complexity: O(n + k)
        public static string FrequencySort(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for(int i =0; i< s.Length;i++)
            {
                if(!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], 1);
                }
                else
                {
                    dic[s[i]]++;
                }
            }
            var sorted_dic = dic.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key);

            StringBuilder sb = new StringBuilder();
            foreach(var d in sorted_dic)
            {
                sb.Append(new string(d.Key, d.Value));
            }

            return sb.ToString();
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Sort Characters By Frequency-----");
            Console.WriteLine(FrequencySort("tree"));
            Console.WriteLine(FrequencySort("cccaaa"));
            Console.WriteLine(FrequencySort(""));
        }
    }
}