using System;
using System.Collections.Generic;

namespace LeetCodeCSharp
{
    public class Fizz_Buzz_Transform
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static string FizzBuzz_1(int n, int m)
        {
            string str = "";
            int starNo = n > m ? m : n;
            int endNo = n > m ? n : m;

            for (int i = starNo; i <= endNo; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    str += "FizzBuzz, ";
                    continue;
                }
                if (i % 3 == 0)
                {
                    str += "Fizz, ";
                    continue;
                }
                if (i % 5 == 0)
                {
                    str += "Buzz, ";
                    continue;
                }

                str += i.ToString() + ", ";
            }
            return str.Substring(0, str.Length - 2);
        }

        // Time complexity: O(n)
        // Space complexity: O(n)
        public static string FizzBuzz_2(int n, int m)
        {
            List<string> result = new List<string>();
            int starNo = n > m ? m : n;
            int endNo = n > m ? n : m;

            for (int i = starNo; i <= endNo; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    result.Add("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    result.Add("Buzz");
                    continue;
                }
                result.Add(i.ToString());
            }
            return string.Join(", ", result.ToArray());
        }

        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----FizzBuzz_1-----");
            Console.WriteLine(FizzBuzz_1(1, 3));
            Console.WriteLine(FizzBuzz_1(1, 5));
            Console.WriteLine(FizzBuzz_1(5, 15));

            Console.WriteLine("-----FizzBuzz_2-----");
            Console.WriteLine(FizzBuzz_2(1, 3));
            Console.WriteLine(FizzBuzz_2(1, 5));
            Console.WriteLine(FizzBuzz_2(5, 15));
        }
    }
}