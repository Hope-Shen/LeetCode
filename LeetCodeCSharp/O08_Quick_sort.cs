using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Quick_sort
{
    /*
    Others_Quick_sort
    2021/09/12

    Type: Divide-and-Conquer
    
    Time complexity: O(n log n)
    Space complexity: O(n)
    */

    public class Quick_sort
    {
        public static void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int i = left;
            // assume the last one is Pivot
            int pivot = arr[right];
            int temp;

            for (int j = left; j <= right; j++)
            {
                if (arr[j] < pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                }
            }

            temp = arr[right];
            arr[right] = arr[i];
            arr[i] = temp;
            return i;
        }

        // run code should change this function name with Main instead of fun_Main
        static void _fun_Main(string[] args)
        {
            Console.WriteLine("-----Quick Sort-----");
            int[] arr = { 3, 4, 5, 1, 2 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine(string.Join(", ", arr));

            int[] arr_2 = { 4, 3, 2, 5, 1 };
            QuickSort(arr_2, 0, arr_2.Length - 1);
            Console.WriteLine(string.Join(", ", arr_2));

            int[] arr_3 = { 5, 1, 4, 3, 2 };
            QuickSort(arr_3, 0, arr_3.Length - 1);
            Console.WriteLine(string.Join(", ", arr_3));

            int[] arr_4 = { 5, 1, 4, 3, 2, 2 };
            QuickSort(arr_4, 0, arr_4.Length - 1);
            Console.WriteLine(string.Join(", ", arr_4));

            int[] arr_5 = { 5 };
            QuickSort(arr_5, 0, arr_5.Length - 1);
            Console.WriteLine(string.Join(", ", arr_5));

            int[] arr_6 = { };
            QuickSort(arr_6, 0, arr_6.Length - 1);
            Console.WriteLine(string.Join(", ", arr_6));
        }
    }
}