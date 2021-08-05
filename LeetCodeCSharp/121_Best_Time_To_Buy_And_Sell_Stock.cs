using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCSharp_Best_Time_To_Buy_And_Sell_Stock
{
    /*
    121_Best_Time_To_Buy_And_Sell_Stock
    2021/08/05

    You are given an array prices where prices[i] is the price of a given stock on the ith day.
    You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

    Example 1:
    Input: prices = [7,1,5,3,6,4]
    Output: 5
    Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
    
    Example 2:
    Input: prices = [7,6,4,3,1]
    Output: 0
    Explanation: In this case, no transactions are done and the max profit = 0.
    */
    public class Best_Time_To_Buy_And_Sell_Stock
    {
        // Brute Force 
        // Time complexity: O(n^2)
        // Space complexity: O(1)
        public static int MaxProfit_1(int[] prices)
        {
            if (prices.Length <= 1) return 0;

            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > profit)
                    {
                        profit = prices[j] - prices[i];
                    }
                }
            }
            return profit;
        }

        // Time complexity: O(n)
        // Space complexity: O(1)
        public static int MaxProfit_2(int[] prices)
        {
            int l = 0, r = 1, max = 0;

            while (r < prices.Length)
            {
                if (prices[l] < prices[r])
                {
                    int profit = prices[r] - prices[l];
                    max = Math.Max(max, profit);
                }
                else
                {
                    l++;
                    r = l;
                }
                r++;
            }

            return max;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Max Profit_1-----");
            Console.WriteLine(MaxProfit_1(new int[] { 7, 1, 5, 3, 6, 4 }));
            Console.WriteLine(MaxProfit_1(new int[] { 7, 6, 4, 3, 1 }));
            Console.WriteLine(MaxProfit_1(new int[] { 1, 3, 4, 5, 6 }));
            Console.WriteLine(MaxProfit_1(new int[] { 2, 4, 1 }));
            Console.WriteLine(MaxProfit_1(new int[] { 1 }));
            Console.WriteLine(MaxProfit_1(new int[] { 1, 2 }));
            Console.WriteLine(MaxProfit_1(new int[] { 2, 1, 2, 1, 0, 1, 2 }));

            Console.WriteLine("-----Max Profit_2-----");
            Console.WriteLine(MaxProfit_2(new int[] { 7, 1, 5, 3, 6, 4 }));
            Console.WriteLine(MaxProfit_2(new int[] { 7, 6, 4, 3, 1 }));
            Console.WriteLine(MaxProfit_2(new int[] { 1, 3, 4, 5, 6 }));
            Console.WriteLine(MaxProfit_2(new int[] { 2, 4, 1 }));
            Console.WriteLine(MaxProfit_2(new int[] { 1 }));
            Console.WriteLine(MaxProfit_2(new int[] { 1, 2 }));
            Console.WriteLine(MaxProfit_2(new int[] { 2, 1, 2, 1, 0, 1, 2 }));
        }
    }
}