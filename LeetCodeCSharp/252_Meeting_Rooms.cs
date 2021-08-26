using System;
using System.Linq;

namespace LeetCodeCSharp_Meeting_Rooms
{
    /*
    252_Meeting_Rooms
    2021/08/20

    Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), determine if a person could attend all meetings.

    Example 1:
    Input: 
    [[0,30],[5,10],[15,20]]

    Output: false
    
    Example 2:
    Input: [[7,10],[2,4]]
    Output: true
    */
    public class Meeting_Rooms
    {
        // Time complexity: O(n log n)
        // Space complexity: O(1)
        public static bool CanAttendMeetings_1(int[][] intervals)
        {
            if (intervals.Length <= 1) return true;
            //[0, 30] [15, 20] [5, 10]
            Array.Sort(intervals, (a, b) => a[0] - b[0]);
            //[0, 30] [5, 10] [15, 20]
            int[] start = new int[intervals.Length];
            int[] end = new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];
            }
            // start[0, 5, 15]
            // end[30, 10, 20]

            int min = start[0];
            int max = end[0];
            // just need to care about start
            // check next start <= before end -> ture then the meeting conflict
            //                                -> false then update the max and going on
            for (int j = 1; j < start.Length; j++)
            {
                if (start[j] <= max)
                {
                    return false;
                }
                max = Math.Max(max, end[j]);
            }

            return true;
        }

        // Time complexity: O(n log n)
        // Space complexity: O(1)
        public static bool CanAttendMeetings_2(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0] - b[0]);
            
            for (int j = 0; j < intervals.Length - 1; j++)
            {
                if (intervals[j + 1][0] <= intervals[j][1])
                {
                    return false;
                }
            }

            return true;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Meeting Rooms_1-----");
            int[][] meeting_1_1 = new int[][]
            {
                new int[] {0,30},
                new int[] {5,10},
                new int[] {15,20}
            };
            Console.WriteLine(CanAttendMeetings_1(meeting_1_1));

            int[][] meeting_1_2 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4}
            };
            Console.WriteLine(CanAttendMeetings_1(meeting_1_2));

            int[][] meeting_1_3 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4},
                new int[] {8,15}
            };
            Console.WriteLine(CanAttendMeetings_1(meeting_1_3));

            int[][] meeting_1_4 = new int[][]
            {
                new int[] {7,10}
            };
            Console.WriteLine(CanAttendMeetings_1(meeting_1_4));

            int[][] meeting_1_5 = new int[][]
            {
                new int[] {}
            };
            Console.WriteLine(CanAttendMeetings_1(meeting_1_5));

            int[][] meeting_1_6 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4},
                new int[] {10,15}
            };
            Console.WriteLine(CanAttendMeetings_1(meeting_1_6));

            Console.WriteLine("-----Meeting Rooms_2-----");
            int[][] meeting_2_1 = new int[][]
            {
                new int[] {0,30},
                new int[] {5,10},
                new int[] {15,20}
            };
            Console.WriteLine(CanAttendMeetings_2(meeting_2_1));

            int[][] meeting_2_2 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4}
            };
            Console.WriteLine(CanAttendMeetings_2(meeting_2_2));

            int[][] meeting_2_3 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4},
                new int[] {8,15}
            };
            Console.WriteLine(CanAttendMeetings_2(meeting_2_3));

            int[][] meeting_2_4 = new int[][]
            {
                new int[] {7,10}
            };
            Console.WriteLine(CanAttendMeetings_2(meeting_2_4));

            int[][] meeting_2_5 = new int[][]
            {
                new int[] {}
            };
            Console.WriteLine(CanAttendMeetings_2(meeting_2_5));

            int[][] meeting_2_6 = new int[][]
            {
                new int[] {7,10},
                new int[] {2,4},
                new int[] {10,15}
            };
            Console.WriteLine(CanAttendMeetings_2(meeting_2_6));
        }
    }
}