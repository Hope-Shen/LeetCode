using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Merge_Sort
{
    /*
    Others_Merge_Sort
    2021/08/26

    Type: Divide-and-Conquer
    Apporach:
        1. find the middle point to divided to subarray (given array length / 2)
        2. left = 0 to mid, right = mid +1, given array length
        3. recursively merge left and right and 
            each step add result into array and remove the left/right when it has been added
            
            loop while left "AND" right is empty
                if left "OR" right is not empty
                    if left.first < right.first
                        add left.first into result array
                    else
                        add right.first into result array
                else if left is not empty
                    add left.first  into result array
                else if right is not empty
                    add right.first  into result array

    Time complexity: O(n log n)
    Space complexity: O(n)
    */

    public class Merge_Sort
    {
        public static int[] MergeSort(int[] val)
        {
            if (val.Length <= 1) return val;
            int mid = val.Length / 2;

            int[] left_arr = new int[mid - 1 + 1];
            int[] right_arr = new int[val.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left_arr[i] = val[i];
            }

            for (int j = 0; j < val.Length - mid; j++)
            {
                right_arr[j] = val[j + mid];
            }
            left_arr = MergeSort(left_arr);
            right_arr = MergeSort(right_arr);
            return merge(left_arr, right_arr);
        }

        public static int[] merge(int[] left, int[] right)
        {
            List<int> result = new List<int>();
            List<int> left_ls = new List<int>();
            left_ls.AddRange(left);
            List<int> right_ls = new List<int>();
            right_ls.AddRange(right);

            while (left_ls.Count > 0 || right_ls.Count > 0)
            {
                // both left and right not empty
                if (left_ls.Count > 0 && right_ls.Count > 0)
                {
                    // if left < right then save left
                    if (left_ls[0] < right_ls[0])
                    {
                        result.Add(left_ls[0]);
                        left_ls.RemoveAt(0);
                    }
                    // if left >= right then save right
                    else
                    {
                        result.Add(right_ls[0]);
                        right_ls.RemoveAt(0);
                    }
                }
                // rest of left
                else if (left_ls.Count > 0)
                {
                    result.Add(left_ls[0]);
                    left_ls.RemoveAt(0);
                }
                // rest of right
                else if (right_ls.Count > 0)
                {
                    result.Add(right_ls[0]);
                    right_ls.RemoveAt(0);
                }
            }
            return result.ToArray();
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Insertion Sort-----");
            int[] arr = { 3, 4, 5, 1, 2 };
            Console.WriteLine(string.Join(", ", MergeSort(arr)));

            int[] arr_2 = { 4, 3, 2, 5, 1 };
            Console.WriteLine(string.Join(", ", MergeSort(arr_2)));

            int[] arr_3 = { 5, 1, 4, 3, 2 };
            Console.WriteLine(string.Join(", ", MergeSort(arr_3)));

            int[] arr_4 = { 5, 1, 4, 3, 2, 2 };
            Console.WriteLine(string.Join(", ", MergeSort(arr_4)));

            int[] arr_5 = { 5 };
            Console.WriteLine(string.Join(", ", MergeSort(arr_5)));

            int[] arr_6 = { };
            Console.WriteLine(string.Join(", ", MergeSort(arr_6)));
        }
    }
}