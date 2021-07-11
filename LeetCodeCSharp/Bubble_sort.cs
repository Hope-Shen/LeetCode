using System;

namespace LeetCodeCSharp_Bubble_Sort
{
    /*
    Other_Bubble_Sort
    2021/07/11
    */

    public class Bubble_Sort
    {
        public static int[] BubbleSort(int[] val) 
        {
            int temp;
            for (int i = 0; i <= 3; i++)
            {
                for (int j = i + 1; j <= 4; j++)
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
            int[] arr = {3, 4, 5, 1, 2};
            // int [] result = ;
            Console.WriteLine(string.Join(", ", BubbleSort(arr)));

            int[] arr_2 = { 4, 3, 2, 5, 1 };
            Console.WriteLine(string.Join(", ", BubbleSort(arr_2)));
        }
    }
}