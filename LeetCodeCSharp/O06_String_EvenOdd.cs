using System;
using System.Text;

namespace LeetCodeCSharp_String_EvenOdd
{
    /*
    O06_String_EvenOdd
    2021/09/12

    
    */

    public class Merge_Sort
    {
        // Time complexity: O(n)
        // Space complexity: O(n)
        public static string EvenOdd(string str)
        {
            if (str.Length == 0) return "";
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length - 1; i++)
            {
                result.Append(str[i]);
                if (str[i] % 2 == str[i + 1] % 2)
                {
                    if (str[i] % 2 == 0)
                    {
                        result.Append("*");
                    }
                    else
                    {
                        result.Append("-");
                    }
                }
            }
            result.Append(str[str.Length - 1]);
            return result.ToString();
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----String EvenOdd-----");
            Console.WriteLine(EvenOdd("21462675756"));
            Console.WriteLine(EvenOdd("98676555533"));
            Console.WriteLine(EvenOdd("11111111"));
            Console.WriteLine(EvenOdd("22222222"));
            Console.WriteLine(EvenOdd("12121212"));
            Console.WriteLine(EvenOdd("12"));
            Console.WriteLine(EvenOdd("1"));
            Console.WriteLine(EvenOdd(""));
        }
    }
}