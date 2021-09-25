using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCSharp_Reorder_Data_Log_Files
{
    /*
    937_Reorder Data in Log Files
    2021/09/25
 
    You are given an array of logs. Each log is a space-delimited string of words, 
    where the first word is the identifier.

    There are two types of logs:
    Letter-logs: All words (except the identifier) consist of lowercase English letters.
    Digit-logs: All words (except the identifier) consist of digits.
    
    Reorder these logs so that:
    1. The letter-logs come before all digit-logs.
    2. The letter-logs are sorted lexicographically by their contents. If their contents are the same, 
        then sort them lexicographically by their identifiers.
    3. The digit-logs maintain their relative ordering.
    
    Return the final order of the logs.

    Example 1:
    Input: logs = 
    ["dig1 8 1 5 1",
     "let1 art can",
     "dig2 3 6",
     "let2 own kit dig",
     "let3 art zero"]
    Output: 
    ["let1 art can",
     "let3 art zero",
     "let2 own kit dig",
     "dig1 8 1 5 1",
     "dig2 3 6"]
    Explanation:
    The letter-log contents are all different, so their ordering is "art can", "art zero", "own kit dig".
    The digit-logs have a relative order of "dig1 8 1 5 1", "dig2 3 6".
    
    Example 2:
    Input: logs = ["a1 9 2 3 1","g1 act car","zo4 4 7","ab1 off key dog","a8 act zoo"]
    Output: ["g1 act car","a8 act zoo","ab1 off key dog","a1 9 2 3 1","zo4 4 7"]
    */
    public class Reorder_Data_Log_Files
    {
        // Time complexity: O(n log n)
        // Space complexity: O(n)
        public static string[] ReorderLogFiles(string[] logs)
        {
            List<string> result = new List<string>();
            List<string> letter = new List<string>();
            List<string> dig = new List<string>();

            foreach (string s in logs)
            {
                if (char.IsDigit(s[s.IndexOf(' ') + 1]))
                {
                    dig.Add(s);
                }
                else
                {
                    letter.Add(s);
                }
            }
            result = letter.OrderBy(x => x.Substring(x.IndexOf(' ') + 1)).ThenBy(y => y.Substring(0, y.IndexOf(' '))).ToList();

            result.AddRange(dig);

            return result.ToArray();
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Reorder Data in Log Files-----");
            Console.WriteLine(string.Join(", ", ReorderLogFiles(new string[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" })));
            Console.WriteLine(string.Join(", ", ReorderLogFiles(new string[] { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" })));
            Console.WriteLine(string.Join(", ", ReorderLogFiles(new string[] { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo", "a2 act car" })));
        }
    }
}