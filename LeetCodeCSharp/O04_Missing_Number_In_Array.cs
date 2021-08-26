using System;
using System.Linq;

namespace LeetCodeCSharp_Missing_Number_In_Array
{
    /*
    Others_Missing_Number_In_Array
    2021/08/21

    You are given an array of positive numbers from 1 to n, 
    such that all numbers from 1 to n are present except one number x. You have to find x. 
    The input array is not sorted. 
    Look at the below array and give it a try before checking the solution.

    [3,7,1,2,8,4,5] n = 8
    -> missing number = 6

    source: https://www.educative.io/blog/crack-amazon-coding-interview-questions
    */

    public class Missing_Number_In_Array
    {
        // Time complexity: O(n) -> sum of array require a liner scan
        // Space complexity: O(1)
        public static int find_missing(int[] val)
        {
            int curr_sum = val.Sum();
            int n = val.Length + 1;
            int actual_sum = (n * (n + 1)) / 2;
            return actual_sum - curr_sum;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Missing Number In Array-----");
            int[] arr = { 3, 5, 1, 2 };
            Console.WriteLine(string.Join(", ", find_missing(arr)));

            int[] arr_2 = { 4, 3, 2, 5, 1, 7, 8 };
            Console.WriteLine(string.Join(", ", find_missing(arr_2)));

            int[] arr_3 = { 5, 1, 4, 3 };
            Console.WriteLine(string.Join(", ", find_missing(arr_3)));
        }
    }
}