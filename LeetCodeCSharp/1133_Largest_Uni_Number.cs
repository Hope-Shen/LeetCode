using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Largest_Uni_Number
{
    /*
    1133_Largest Unique Number
    2021/09/12

    Given an array of integers A, return the largest integer that only occurs once.

    If no integer occurs once, return -1.

    Example 1:
    Input: [5,7,3,9,4,9,8,3,1]
    Output: 8
    Explanation: 
    The maximum integer in the array is 9 but it is repeated. The number 8 occurs only once, so it's the answer.
    
    Example 2:
    Input: [9,9,8,8]
    Output: -1
    Explanation: 
    There is no number that occurs only once.
    */
    public class Largest_Uni_Number
    {
        // Time complexity: O(n)
        // Space complexity: O(n)
        public static int largestUniqueNumber(int[] A)
        {
            int result = -1;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i <= A.Length - 1; i++)
            {
                if (dic.ContainsKey(A[i]))
                {
                    dic[A[i]]++;
                }
                else
                {
                    dic.Add(A[i], 1);
                }
            }

            for (int j = 0; j < dic.Count; j++)
            {
                if (dic[A[j]] == 1)
                {
                    result = Math.Max(result, A[j]);
                }
            }
            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Ransom Note-----");
            Console.WriteLine(largestUniqueNumber(new int[] { 5, 7, 3, 9, 4, 9, 8, 3, 1 }));
            Console.WriteLine(largestUniqueNumber(new int[] { 9, 9, 8, 8 }));
            Console.WriteLine(largestUniqueNumber(new int[] { 1, 1, 1, 1, 1 }));
            Console.WriteLine(largestUniqueNumber(new int[] { 1 }));
            Console.WriteLine(largestUniqueNumber(new int[] {  }));
        }
    }
}