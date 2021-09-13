using System;
using System.Linq;

namespace LeetCodeCSharp_Check_Straight_Line
{
    /*
    1232_Check If It Is a Straight Line
    2021/09/12
 
    You are given an array coordinates, coordinates[i] = [x, y], where [x, y] represents the coordinate of a point. 
    Check if these points make a straight line in the XY plane.

    Example 1:
    Input: coordinates = [[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
    Output: true
    
    Example 2:
    Input: coordinates = [[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]
    Output: false
    */
    public class Check_Straight_Line
    {
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length <= 1) return false;
            for (int i = 1; i < coordinates.Length - 1; i++)
            {
                // slope => x2-x1 / y2-y1
                if ((coordinates[i][0] - coordinates[0][0]) * (coordinates[i + 1][1] - coordinates[0][1]) !=
                    (coordinates[i + 1][0] - coordinates[0][0]) * (coordinates[i][1] - coordinates[0][1])
                 )
                {
                    return false;
                }
            }

            return true;
        }

        // run code should change this function name with Main instead of fun_Main
        static void Main(string[] args)
        {
            Console.WriteLine("-----Check If It Is a Straight Line-----");
            int[][] coordinates = new int[][]
            {
                new int[] {1,2},
                new int[] {2,3},
                new int[] {3,4},
                new int[] {4,5}
            };
            Console.WriteLine(CheckStraightLine(coordinates));

            int[][] coordinates_2 = new int[][]
            {
                new int[] {1,2},
                new int[] {2,2},
                new int[] {3,4},
                new int[] {4,5}
            };
            Console.WriteLine(CheckStraightLine(coordinates_2));
        }
    }
}