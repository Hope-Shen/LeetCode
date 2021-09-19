using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Pascals_Triangle
{
    /*
    118_Pascals_Triangle
    2021/08/15

    Given an integer numRows, return the first numRows of Pascal's triangle.
    In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

    Example 1:
    Input: numRows = 5
    Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
    
    Example 2:
    Input: numRows = 1
    Output: [[1]]
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