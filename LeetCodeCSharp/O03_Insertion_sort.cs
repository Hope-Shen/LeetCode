using System;

namespace LeetCodeCSharp_Insertion_Sort
{
    /*
    Others_Insertion_Sort
    2021/07/27

    Time complexity: O(n^2)
    */

    public class Insertion_Sort
    {
        public static int[] InsertionSort(int[] val) 
        {
            int val_len = val.Length;
            for (int i = 1; i < val.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (val[j + 1] < val[j])
                    {
                        int swap_val;
                        swap_val = val[j + 1];
                        val[j + 1] = val[j];
                        val[j] = swap_val;
                    }
                    else 
                    {
                        break;
                    }
                    // Console.WriteLine(i + " :" + string.Join(", ", val));
                }
            }
            return val;
        }
        
        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
           Console.WriteLine("-----Insertion Sort-----");
            int[] arr = {3, 4, 5, 1, 2};
            Console.WriteLine(string.Join(", ", InsertionSort(arr)));

            int[] arr_2 = { 4, 3, 2, 5, 1 };
            Console.WriteLine(string.Join(", ", InsertionSort(arr_2)));
            
            int[] arr_3 = { 5, 1, 4, 3, 2 };
            Console.WriteLine(string.Join(", ", InsertionSort(arr_3)));
        }
    }
}