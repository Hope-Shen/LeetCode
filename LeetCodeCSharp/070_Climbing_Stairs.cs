using System;

namespace LeetCodeCSharp_Climbing_Stairs
{
    /*
    070_Climbing Stairs
    2021/09/13

    You are climbing a staircase. It takes n steps to reach the top.
    Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

    Example 1:
    Input: n = 2
    Output: 2
    Explanation: There are two ways to climb to the top.
    1. 1 step + 1 step
    2. 2 steps
    
    Example 2:
    Input: n = 3
    Output: 3
    Explanation: There are three ways to climb to the top.
    1. 1 step + 1 step + 1 step
    2. 1 step + 2 steps
    3. 2 steps + 1 step
    */

    public class Climbing_Stairs
    {
        // Dynamic Programming
        // Time complexity: O(n)
        // Space complexity: O(n)
        public static int ClimbStairs(int n)
        {
            if (n == 0 || n == 1) return n;
            int[] result = new int[n];
            result[0] = 1;
            result[1] = 2;
            for (int i = 2; i < n; i++)
            {
                result[i] = result[i - 2] + result[i - 1];
            }
            return result[n - 1];
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Climbing Stairs-----");
            Console.WriteLine(ClimbStairs(0));
            Console.WriteLine(ClimbStairs(1));
            Console.WriteLine(ClimbStairs(2));
            Console.WriteLine(ClimbStairs(3));
            Console.WriteLine(ClimbStairs(4));
            Console.WriteLine(ClimbStairs(10));
        }
    }
}