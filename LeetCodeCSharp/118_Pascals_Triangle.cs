using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Pascals_Triangle
{
    /*
    118_Pascals_Triangle
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
    public class Pascals_Triangle
    {
        // Time complexity: O(n^2)
        // Space complexity: O(1)
        public static IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> result = new List<IList<int>>();
            // if (numRows <= 0) return result;
            // result.Add(new List<int>(1) { 1 });
            // if (numRows == 1) return result;
            // result.Add(new List<int>(2) { 1, 1 });
            // if (numRows == 2) return result;

            // for (int i = 2; i < numRows; i++)
            // {
            //     List<int> temp = new List<int>(i + 1);
            //     temp.Add(1);
            //     for (int j = 1; j < i; j++)
            //     {
            //         temp.Add(result[i - 1][j - 1] + result[i - 1][j]);
            //     }
            //     temp.Add(1);
            //     result.Add(temp);
            // }

            for (int i = 0; i < numRows; i++)
            {
                List<int> temp = new List<int>(1);
                if (i != 0) temp.Add(1);
                for (int j = 1; j < i; j++)
                {
                    temp.Add(result[i - 1][j - 1] + result[i - 1][j]);
                }
                temp.Add(1);
                result.Add(temp);
            }

            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Pascal's Triangle-----");
            Console.WriteLine(Generate(3));
            Console.WriteLine(Generate(5));
        }
    }
}