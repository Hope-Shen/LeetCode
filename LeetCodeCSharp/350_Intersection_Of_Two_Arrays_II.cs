using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCSharp_Intersection_Of_Two_Arrays_II
{
    /*
    350_Intersection_Of_Two_Arrays_II
    2021/08/03

    Given two integer arrays nums1 and nums2, return an array of their intersection. 
    Each element in the result must appear as many times as it shows in both arrays and 
    you may return the result in any order.

    Example 1:
    Input: nums1 = [1,2,2,1], nums2 = [2,2]
    Output: [2,2]
    
    Example 2:
    Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
    Output: [4,9]
    Explanation: [9,4] is also accepted.
    */
    public class Intersection_Of_Two_Arrays_II
    {
        // Time complexity: O(m+n)
        // Space complexity: O(1)
        public static int[] Intersect_1(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        result.Add(nums1[i]);
                        nums2 = nums2.Where((val, idx) => idx != j).ToArray();
                        break;
                    }
                }
            }
            return result.ToArray();
        }

        // Time complexity: O(mlogm+nlogn)
        // Space complexity: O(1)
        public static int[] Intersect_2(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);

            int i = 0, j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    result.Add(nums1[i]);
                    i++;
                    j++;
                    continue;
                }
                else if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return result.ToArray();
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Intersect Two Array_1-----");
            Console.WriteLine(string.Join(",", Intersect_1(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 })));
            Console.WriteLine(string.Join(",", Intersect_1(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 })));
            Console.WriteLine(string.Join(",", Intersect_1(new int[] { 1 }, new int[] { 2 })));
            Console.WriteLine(string.Join(",", Intersect_1(new int[] { }, new int[] { 2, 3 })));
            Console.WriteLine(string.Join(",", Intersect_1(new int[] { 1, 2, 2, 1 }, new int[] { 2 })));
            Console.WriteLine(string.Join(",", Intersect_1(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 })));

            Console.WriteLine("-----Intersect Two Array_2-----");
            Console.WriteLine(string.Join(",", Intersect_2(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 })));
            Console.WriteLine(string.Join(",", Intersect_2(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 })));
            Console.WriteLine(string.Join(",", Intersect_2(new int[] { 1 }, new int[] { 2 })));
            Console.WriteLine(string.Join(",", Intersect_2(new int[] { }, new int[] { 2, 3 })));
            Console.WriteLine(string.Join(",", Intersect_2(new int[] { 1, 2, 2, 1 }, new int[] { 2 })));
            Console.WriteLine(string.Join(",", Intersect_2(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 })));
        }
    }
}