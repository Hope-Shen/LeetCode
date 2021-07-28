using System;

namespace LeetCodeCSharp_Selection_Sort
{
    /*
    Others_Selection_Sort
    2021/07/23

    Time complexity: O(n^2)
    */

    public class Selection_Sort
    {
        public static int[] SelectionSort(int[] val) 
        {
            int val_len = val.Length;
            for (int i = 0; i < val_len - 1; i++)
            {
                int temp = i;
                for (int j = i + 1; j < val_len; j++)
                {
                    temp = val[temp] > val[j] ? j : temp;
                }
                int swap_val;
                swap_val = val[i];
                val[i] = val[temp];
                val[temp] = swap_val;

                // Console.WriteLine(i + " :" + string.Join(", ", val));
            }
            return val;
        }
        
        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
           Console.WriteLine("-----Selection Sort-----");
            int[] arr = {3, 4, 5, 1, 2};
            Console.WriteLine(string.Join(", ", SelectionSort(arr)));

            int[] arr_2 = { 4, 3, 2, 5, 1 };
            Console.WriteLine(string.Join(", ", SelectionSort(arr_2)));
            
            int[] arr_3 = { 5, 1, 4, 3, 2 };
            Console.WriteLine(string.Join(", ", SelectionSort(arr_3)));
        }
    }
}