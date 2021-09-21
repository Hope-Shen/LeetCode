using System;
using System.Collections.Generic;

namespace LeetCodeCSharp_Array_Left_Rotation
{
    /*
    Others_Array Left Rotation
    2021/09/21
    https://www.geeksforgeeks.org/array-rotation/

    A left rotation operation on an array shifts each of the array's elements  unit to the left. For example, if  left rotations are performed on array , then the array would become . Note that the lowest index item moves to the highest index in a rotation. This is called a circular array.

    Given an array  of  integers and a number, , perform  left rotations on the array. Return the updated array to be printed as a single line of space-separated integers.

    Function Description
    Complete the function rotLeft in the editor below.
    rotLeft has the following parameter(s):
    int a[n]: the array to rotate
    int d: the number of rotations
    
    Returns
    int a'[n]: the rotated array
    
    Input Format
    The first line contains two space-separated integers  and , the size of  and the number of left rotations.
    The second line contains  space-separated integers, each an .

    Sample Input
    5 4
    1 2 3 4 5
    Sample Output

    5 1 2 3 4

    Time complexity: O(n)
    Space complexity: O(n)
    */

    public class Array_Left_Rotation
    {
        public static List<int> rotLeft(List<int> a, int d)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (i >= d)
                {
                    result.Insert(i - d, a[i]);
                }
                else
                {
                    result.Add(a[i]);
                }
            }

            return result;
        }
        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Array Left Rotation-----");
            Console.WriteLine(string.Join(", ", rotLeft(new List<int> { 1, 2, 3, 4, 5 }, 2)));
        }
    }
}