using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCSharp_How_Many_Apple_In_Backet
{
    /*
    1196_How Many Apples Can You Put into the Basket
    2021/09/13
 
    You have some apples, where arr[i] is the weight of the i-th apple.  
    You also have a basket that can carry up to 5000 units of weight.
    Return the maximum number of apples you can put in the basket.

    Example 1:
    Input: arr = [100,200,150,1000]
    Output: 4
    Explanation: All 4 apples can be carried by the basket since their sum of weights is 1450.
    
    Example 2:
    Input: arr = [900,950,800,1000,700,800]
    Output: 5
    Explanation: The sum of weights of the 6 apples exceeds 5000 so we choose any 5 of them.
    */
    public class How_Many_Apple_In_Backet
    {
        // Time complexity: O(log n)
        // Space complexity: O(1)
        public static int MaxNumberOfApples(int[] arr)
        {
            int sum = 0;
            int Max = 5000;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (sum + arr[i] > Max)
                {
                    return i;
                }
                sum += arr[i];
            }
            return arr.Length;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Last Stone Weight-----");
            Console.WriteLine(MaxNumberOfApples(new int[] { 100, 200, 150, 1000 }));
            Console.WriteLine(MaxNumberOfApples(new int[] { 900, 950, 800, 1000, 700, 800 }));
            Console.WriteLine(MaxNumberOfApples(new int[] { 1000, 2000, 1200, 1000 }));
            Console.WriteLine(MaxNumberOfApples(new int[] { 5000, 5 }));
            Console.WriteLine(MaxNumberOfApples(new int[] { 4999, 1 }));
            Console.WriteLine(MaxNumberOfApples(new int[] { 5005 }));
            Console.WriteLine(MaxNumberOfApples(new int[] { }));
        }
    }
}