using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCSharp_Last_Stone_Weight
{
    /*
    1046_Last Stone Weight
    2021/09/13
 
    You are given an array of integers stones where stones[i] is the weight of the ith stone.
    We are playing a game with the stones. On each turn, we choose the heaviest two stones and smash them together. 
    Suppose the heaviest two stones have weights x and y with x <= y. The result of this smash is:

    If x == y, both stones are destroyed, and
    If x != y, the stone of weight x is destroyed, and the stone of weight y has new weight y - x.
    At the end of the game, there is at most one stone left.

    Return the smallest possible weight of the left stone. If there are no stones left, return 0.

    Example 1:
    Input: stones = [2,7,4,1,8,1]
    Output: 1
    Explanation: 
    We combine 7 and 8 to get 1 so the array converts to [2,4,1,1,1] then,
    we combine 2 and 4 to get 2 so the array converts to [2,1,1,1] then,
    we combine 2 and 1 to get 1 so the array converts to [1,1,1] then,
    we combine 1 and 1 to get 0 so the array converts to [1] then that's the value of the last stone.
    
    Example 2:
    Input: stones = [1]
    Output: 1
    */
    public class Last_Stone_Weight
    {
        // Time complexity: O(n log n)
        // Space complexity: O(n)
        public static int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 0) return 0;

            List<int> ls = new List<int>(stones);

            while (ls.Count() > 1)
            {
                // sort the array in reverse
                ls.Sort();
                ls.Reverse();

                int subtract = ls[0] - ls[1];
                if (subtract >= 1)
                {
                    ls.Add(subtract);
                }
                // remove the first element. b/c remove first one, then the orginal second will become first element
                ls.Remove(ls[0]);
                ls.Remove(ls[0]);
            }

            return ls.FirstOrDefault();
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Last Stone Weight-----");
            Console.WriteLine(LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 }));
            Console.WriteLine(LastStoneWeight(new int[] { 1 }));
            Console.WriteLine(LastStoneWeight(new int[] { 2, 7, 4, 1, 9, 1 }));
            Console.WriteLine(LastStoneWeight(new int[] { 3, 4, 1, 5, 1 }));
            Console.WriteLine(LastStoneWeight(new int[] { }));
        }
    }
}