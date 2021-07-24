using System;

namespace LeetCodeCSharp_Bubble_Sort
{
    /*
    Others_Bubble_Sort
    2021/07/11
    */

    public class Bubble_Sort
    {
        public static int[] BubbleSort(int[] val) 
        {
            int val_len = val.Length;
            int temp;
            for (int i = 0; i < val_len - 1; i++)
            {
                for (int j = i + 1; j < val_len; j++)
                {
                    if (val[i] > val[j])
                    {
                        temp = val[j];
                        val[j] = val[i];
                        val[i] = temp;
                    }
                }
                // Console.WriteLine(i + " :" + string.Join(", ", val));
            }
            return val;
        }
        
        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
           Console.WriteLine("-----Bubble Sort-----");
            int[] arr_1 = {3, 4, 5, 1, 2};
            Console.WriteLine(string.Join(", ", BubbleSort(arr_1)));

            int[] arr_2 = { 4, 3, 2, 5, 1 };
            Console.WriteLine(string.Join(", ", BubbleSort(arr_2)));

            int[] arr_3 = { 5, 1, 4, 3, 2 };
            Console.WriteLine(string.Join(", ", BubbleSort(arr_3)));
        }
    }
}