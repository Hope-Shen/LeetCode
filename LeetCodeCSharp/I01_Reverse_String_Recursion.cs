using System;

namespace LeetCodeCSharp_Reverse_String_Recursion
{
    /*
    I01_Reverse_String_Recursion
    2021/08/17

    Give a string and return a reverse string by using recursion
    */

    public class Reverse_String_Recursion
    {
        public static string reverse(String str)
        {
            if (str == "" || str.Length == 0) return "";

            return str[str.Length - 1] + reverse(str.Substring(0, str.Length - 1));
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Reverse String Recursion-----");
            Console.WriteLine(reverse("abc"));
            Console.WriteLine(reverse("0123456789"));
            Console.WriteLine(reverse(""));
        }
    }
}