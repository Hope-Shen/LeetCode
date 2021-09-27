using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCSharp_Route_Pairs
{
    /*
    I04_Route Pairs
    2021/09/26

    Closest pair sum.

    Example 1:
    Input:
    maxTravelDist = 7000
    forwardRouteList = [[1,2000],[2,4000],[3,6000]]
    returnRouteList = [[1,2000]]

    Output: 
    [[2,1]]

    Example 2:
    Input:
    maxTravelDist = 10000
    forwardRouteList = [[1, 3000], [2, 5000], [3, 7000],[4, 10000]]
    returnRouteList = [[1, 2000], [2,3000], [3, 4000], [4,5000]]

    Output:
    [[2, 4], [3, 2]]
    */

    public class Route_Pairs
    {
        // Time complexity: O(n*m)
        // Space complexity: O(n)
        public static List<List<int>> routePairs(int maxTraveDist, List<List<int>> forwardRouteList, List<List<int>> returnRouteList)
        {
            List<List<int>> result = new List<List<int>>();
            int max = 0;

            forwardRouteList.Sort((a, b) => b[1] - a[1]);
            returnRouteList.Sort((a, b) => b[1] - a[1]);

            foreach (var f in forwardRouteList)
            {
                foreach (var r in returnRouteList)
                {
                    if (f[1] + r[1] <= maxTraveDist)
                    {
                        // result.Add(new List<int>{ f[0],r[0]});
                        max = Math.Max(max, f[1] + r[1]);
                        if (f[1] + r[1] >= max)
                        {
                            result.Add(new List<int> { f[0], r[0] });
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            if (max == 0) result.Add(new List<int> { 0, 0 });

            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            List<List<int>> forwardRouteList_1 = new List<List<int>>();
            forwardRouteList_1.Add(new List<int>() { 1, 2000 });
            forwardRouteList_1.Add(new List<int>() { 2, 4000 });
            forwardRouteList_1.Add(new List<int>() { 3, 6000 });
            List<List<int>> returnRouteList_1 = new List<List<int>>();
            returnRouteList_1.Add(new List<int>() { 1, 2000 });
            routePairs(7000, forwardRouteList_1, returnRouteList_1); // {[2, 1]}

            List<List<int>> forwardRouteList_2 = new List<List<int>>();
            forwardRouteList_2.Add(new List<int>() { 1, 3000 });
            forwardRouteList_2.Add(new List<int>() { 2, 5000 });
            forwardRouteList_2.Add(new List<int>() { 3, 7000 });
            forwardRouteList_2.Add(new List<int>() { 4, 10000 });
            List<List<int>> returnRouteList_2 = new List<List<int>>();
            returnRouteList_2.Add(new List<int>() { 1, 2000 });
            returnRouteList_2.Add(new List<int>() { 2, 3000 });
            returnRouteList_2.Add(new List<int>() { 3, 4000 });
            returnRouteList_2.Add(new List<int>() { 4, 5000 });
            routePairs(10000, forwardRouteList_2, returnRouteList_2); // {[2, 4], [3, 2]}

            List<List<int>> forwardRouteList_3 = new List<List<int>>();
            forwardRouteList_3.Add(new List<int>() { 1, 2000 });
            forwardRouteList_3.Add(new List<int>() { 2, 4000 });
            forwardRouteList_3.Add(new List<int>() { 3, 6000 });
            List<List<int>> returnRouteList_3 = new List<List<int>>();
            returnRouteList_3.Add(new List<int>() { 1, 5000 });
            returnRouteList_3.Add(new List<int>() { 2, 3000 });
            routePairs(7000, forwardRouteList_3, returnRouteList_3); // {[2, 2], [1, 1]}

            List<List<int>> forwardRouteList_4 = new List<List<int>>();
            forwardRouteList_4.Add(new List<int>() { 1, 2000 });
            List<List<int>> returnRouteList_4 = new List<List<int>>();
            returnRouteList_4.Add(new List<int>() { 1, 5000 });
            routePairs(1000, forwardRouteList_4, returnRouteList_4); // {[0, 0]}

            List<List<int>> forwardRouteList_5 = new List<List<int>>();
            forwardRouteList_5.Add(new List<int>() { 1, 3000 });
            forwardRouteList_5.Add(new List<int>() { 2, 5000 });
            forwardRouteList_5.Add(new List<int>() { 3, 4000 });
            forwardRouteList_5.Add(new List<int>() { 4, 10000 });
            List<List<int>> returnRouteList_5 = new List<List<int>>();
            returnRouteList_5.Add(new List<int>() { 1, 2000 });
            returnRouteList_5.Add(new List<int>() { 2, 3000 });
            returnRouteList_5.Add(new List<int>() { 3, 4000 });
            routePairs(11000, forwardRouteList_5, returnRouteList_5); // {[2, 3]}
        }
    }
}