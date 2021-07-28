using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Fizz_Buzz
{
    /*
    412_Fizz_Buzz
    2021/06/22
    Given an integer n, return a string array answer (1-indexed) where:

    answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    answer[i] == "Fizz" if i is divisible by 3.
    answer[i] == "Buzz" if i is divisible by 5.
    answer[i] == i if non of the above conditions are true.
    
    Example 1:
    Input: n = 3
    Output: ["1","2","Fizz"]
    
    Example 2:
    Input: n = 5
    Output: ["1","2","Fizz","4","Buzz"]
    
    Example 3:
    Input: n = 15
    Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
    
    Constraints:
    1 <= n <= 104
    */
    public class Fizz_Buzz
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static IList<string> FizzBuzz_1(int n) {
            List<string> ls = new List<string>();

            for(int i = 1; i <= n; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    ls.Add("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    ls.Add("Fizz");
                }
                else if(i % 5 == 0)
                {
                    ls.Add("Buzz");
                }
                else
                {
                    ls.Add(i.ToString());
                }
            }
            string result = string.Join(", ", ls);
            Console.WriteLine($"RESULT: {result}");
            return ls;
        }

        // Time complexity: O(n)
        // Space complexity: O(1)
        public static IList<string> FizzBuzz_2(int n) {
            List<string> ls = new List<string>();

            for(int i = 1; i <= n; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    ls.Add("FizzBuzz");
                    continue;
                }
                if(i % 3 == 0)
                {
                    ls.Add("Fizz");
                    continue;
                }
                if(i % 5 == 0)
                {
                    ls.Add("Buzz");
                    continue;
                }
                
                ls.Add(i.ToString());
            }
            string result = string.Join(", ", ls);
            Console.WriteLine($"RESULT: {result}");
            return ls;
        }
        
        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----FizzBuzz_1-----");
            FizzBuzz_1(3);
            FizzBuzz_1(5);
            FizzBuzz_1(15);
            Console.WriteLine("-----FizzBuzz_2-----");
            FizzBuzz_2(3);
            FizzBuzz_2(5);
            FizzBuzz_2(15);
        }
    }
}