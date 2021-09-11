using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Element_25_Sorted_Array
{
    /*
    1287_Element Appearing More Than 25% In Sorted Array
    2021/09/10

    Given an integer array sorted in non-decreasing order, 
    there is exactly one integer in the array that occurs more than 25% of the time, return that integer.

    Example 1:
    Input: arr = [1,2,2,6,6,6,6,7,10]
    Output: 6
    
    Example 2:
    Input: arr = [1,1]
    Output: 1
    */

    public class Element_25_Sorted_Array
    {
        // Time complexity: O(n)
        // Space complexity: O(n)
        public static int FindSpecialInteger_1(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int quarter = arr.Length / 4;
            foreach (var i in arr)
            {
                if (dic.ContainsKey(i))
                {
                    dic[i]++;
                }
                else
                {
                    dic.Add(i, 1);
                }
                if (dic[i] > quarter)
                {
                    return i;
                }
            }
            return -1;
        }

        // Time complexity: O(n)
        // Space complexity: O(1)
        public static int FindSpecialInteger_2(int[] arr)
        {
            int count = 0, left = 0, right = 0;
            int len = arr.Length;
            while (right < len)
            {
                if (arr[left] == arr[right])
                {
                    count++;
                    if (count * 4 > len)
                    {
                        return arr[left];
                    }
                }
                else
                {
                    left = right;
                    count = 1;
                }
                right++;
            }
            return -1;
        }

        // Binary search
        // Time complexity: O(log n)
        // Space complexity: O(1)
        public static int FindSpecialInteger_3(int[] arr)
        {
            int quarter = arr.Length / 4;

            for (int i = 0; i < arr.Length - quarter; i++)
            {
                if (arr[i] == arr[i + quarter])
                {
                    return arr[i];
                }
            }
            return -1;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Element Appearing More Than 25% In Sorted Array_1-----");
            Console.WriteLine(FindSpecialInteger_1(new int[] { 1, 2, 3, 6, 6, 6, 6, 7, 10 }));
            Console.WriteLine(FindSpecialInteger_1(new int[] { 1, 2, 2, 2, 6, 6, 6, 6, 7, 10 }));
            Console.WriteLine(FindSpecialInteger_1(new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 }));
            Console.WriteLine(FindSpecialInteger_1(new int[] { 1, 1 }));
            Console.WriteLine(FindSpecialInteger_1(new int[] { 1, 2, 3, 3 }));
            Console.WriteLine(FindSpecialInteger_1(new int[] { 1 }));
            Console.WriteLine(FindSpecialInteger_1(new int[] { 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12, 12, 12 }));

            Console.WriteLine("-----Element Appearing More Than 25% In Sorted Array_2-----");
            Console.WriteLine(FindSpecialInteger_2(new int[] { 1, 2, 3, 6, 6, 6, 6, 7, 10 }));
            Console.WriteLine(FindSpecialInteger_2(new int[] { 1, 2, 2, 2, 6, 6, 6, 6, 7, 10 }));
            Console.WriteLine(FindSpecialInteger_2(new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 }));
            Console.WriteLine(FindSpecialInteger_2(new int[] { 1, 1 }));
            Console.WriteLine(FindSpecialInteger_2(new int[] { 1, 2, 3, 3 }));
            Console.WriteLine(FindSpecialInteger_2(new int[] { 1 }));
            Console.WriteLine(FindSpecialInteger_2(new int[] { 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12, 12, 12 }));

            Console.WriteLine("-----Element Appearing More Than 25% In Sorted Array_3-----");
            Console.WriteLine(FindSpecialInteger_3(new int[] { 1, 2, 3, 6, 6, 6, 6, 7, 10 }));
            Console.WriteLine(FindSpecialInteger_3(new int[] { 1, 2, 2, 2, 6, 6, 6, 6, 7, 10 }));
            Console.WriteLine(FindSpecialInteger_3(new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 }));
            Console.WriteLine(FindSpecialInteger_3(new int[] { 1, 1 }));
            Console.WriteLine(FindSpecialInteger_3(new int[] { 1, 2, 3, 3 }));
            Console.WriteLine(FindSpecialInteger_3(new int[] { 1 }));
            Console.WriteLine(FindSpecialInteger_3(new int[] { 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12, 12, 12 }));
        }
    }
}