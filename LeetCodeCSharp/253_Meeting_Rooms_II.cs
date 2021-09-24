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
        public static int MinMeetingRooms_1(int[][] intervals)
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

        // Time complexity: O(n log n)
        // Space complexity: O(1)
        public static int MinMeetingRooms_2(int[][] intervals)
        {
            if (intervals.Length == 0 || intervals[0].Length == 0) return 0;
            int result = 1;
            Array.Sort(intervals, (a, b) => a[0] - b[0]);

            for (int j = 0; j < intervals.Length - 1; j++)
            {
                if (intervals[j + 1][0] <= intervals[j][1])
                {
                    result++;
                }
            }

            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Meeting Rooms_II_1-----");
            int[][] meeting_11 = new int[][]
            {
                new int[] {0,30},
                new int[] {5,10},
                new int[] {15,20}
            };
            Console.WriteLine(MinMeetingRooms_1(meeting_11));

            int[][] meeting_12 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4}
            };
            Console.WriteLine(MinMeetingRooms_1(meeting_12));

            int[][] meeting_13 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4},
                new int[] {8,15}
            };
            Console.WriteLine(MinMeetingRooms_1(meeting_13));

            int[][] meeting_14 = new int[][]
            {
                new int[] {7,10}
            };
            Console.WriteLine(MinMeetingRooms_1(meeting_14));

            int[][] meeting_15 = new int[][]
            {
                new int[] {}
            };
            Console.WriteLine(MinMeetingRooms_1(meeting_15));

            int[][] meeting_16 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4},
                new int[] {10,15}
            };
            Console.WriteLine(MinMeetingRooms_1(meeting_16));

            int[][] meeting_17 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,8},
                new int[] {6,12}
            };
            Console.WriteLine(MinMeetingRooms_1(meeting_17));

            Console.WriteLine("-----Meeting Rooms_II_2-----");
            int[][] meeting_21 = new int[][]
            {
                new int[] {0,30},
                new int[] {5,10},
                new int[] {15,20}
            };
            Console.WriteLine(MinMeetingRooms_2(meeting_21));

            int[][] meeting_22 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4}
            };
            Console.WriteLine(MinMeetingRooms_2(meeting_22));

            int[][] meeting_23 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4},
                new int[] {8,15}
            };
            Console.WriteLine(MinMeetingRooms_2(meeting_23));

            int[][] meeting_24 = new int[][]
            {
                new int[] {7,10}
            };
            Console.WriteLine(MinMeetingRooms_2(meeting_24));

            int[][] meeting_25 = new int[][]
            {
                new int[] {}
            };
            Console.WriteLine(MinMeetingRooms_2(meeting_25));

            int[][] meeting_26 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4},
                new int[] {10,15}
            };
            Console.WriteLine(MinMeetingRooms_2(meeting_26));

            int[][] meeting_27 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,8},
                new int[] {6,12}
            };
            Console.WriteLine(MinMeetingRooms_2(meeting_27));
        }
    }
}