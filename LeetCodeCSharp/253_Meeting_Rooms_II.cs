using System;
using System.Linq;

namespace LeetCodeCSharp_Meeting_Rooms_II
{
    /*
    253_Meeting_Rooms_II
    2021/08/20

    Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), 
    find the minimum number of conference rooms required.

    Example 1:
    Input: 
    [[0, 30],[5, 10],[15, 20]]

    Output: 2
    
    Example 2:
    Input: [[7,10],[2,4]]
    Output: 1
    */
    public class Meeting_Rooms_II
    {
        // Time complexity: O(n log n)
        // Space complexity: O(n)
        public static int MinMeetingRooms(int[][] intervals)
        {
            if (intervals.Length == 0 || intervals[0].Length == 0) return 0;

            //[0, 30] [5, 10] [15, 20]
            int[] start_arr = new int[intervals.Length];
            int[] end_arr = new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
            {
                start_arr[i] = intervals[i][0];
                end_arr[i] = intervals[i][1];
            }
            
            // start[0, 5, 15]
            // end[30, 10, 20]
            Array.Sort(start_arr);
            Array.Sort(end_arr);

            // after sorted: start[0, 5, 15]
            // after sorted: end[10, 20, 30]

            int end = 0;
            int count = 0;
            // just need to care about start
            // 0 start[0] < end[0] -> 0 < 10  then room + 1, start pointer + 1
            // 1 start[1] < end[0] -> 5 < 10  then room + 1, start pointer + 1
            // 2 start[2] < end[0] -> 15 < 10 then room + 0, start pointer + 1 and end pointer + 1
            // 3 pointer 3 is end of the array so stop
            //                               total room = 2 
            for (int i = 0; i < start_arr.Length; i++)
            {
                if (start_arr[i] <= end_arr[end])
                {
                    count++;
                }
                else
                {
                    end++;
                }
            }

            return count;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Meeting Rooms_II-----");
            int[][] meeting_1 = new int[][]
            {
                new int[] {0,30},
                new int[] {5,10},
                new int[] {15,20}
            };
            Console.WriteLine(MinMeetingRooms(meeting_1));

            int[][] meeting_2 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4}
            };
            Console.WriteLine(MinMeetingRooms(meeting_2));

            int[][] meeting_3 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4},
                new int[] {8,15}
            };
            Console.WriteLine(MinMeetingRooms(meeting_3));

            int[][] meeting_4 = new int[][]
            {
                new int[] {7,10}
            };
            Console.WriteLine(MinMeetingRooms(meeting_4));

            int[][] meeting_5 = new int[][]
            {
                new int[] {}
            };
            Console.WriteLine(MinMeetingRooms(meeting_5));

            int[][] meeting_6 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4},
                new int[] {10,15}
            };
            Console.WriteLine(MinMeetingRooms(meeting_6));

            int[][] meeting_7 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,8},
                new int[] {6,12}
            };
            Console.WriteLine(MinMeetingRooms(meeting_7));
        }
    }
}