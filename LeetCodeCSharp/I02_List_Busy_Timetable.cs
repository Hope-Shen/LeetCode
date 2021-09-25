using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCSharp_List_Busy_Timetable
{
    /*
    I02_List Busy TImetable
    2021/09/25

    Can reference to #252 and #253
    Check first.end <= next.begin -> the time overleap
    */

    public class timetable
    {
        public int begin { get; set; }
        public int end { get; set; }
        public string title { get; set; }
    }
    public class List_Busy_Timetable
    {
        // Time complexity: O(n)
        // Space complexity: O(n)
        public static List<timetable> busy_time(List<timetable> t)
        {
            List<timetable> result = new List<timetable>();

            // order by begin time then end time by ascending order          
            // { begin = 100, end = 300, title = "meeting_03" }
            // { begin = 200, end = 230, title = "meeting_02" }
            // { begin = 250, end = 310, title = "meeting_01" }
            // { begin = 500, end = 600, title = "meeting_04" }
            // { begin = 600, end = 700, title = "meeting_05" }
            List<timetable> sorted_t = t.OrderBy(b => b.begin).ThenBy(e => e.end).ToList();

            int min = sorted_t[0].begin; // first row for default min value -> [0] 100
            int max = sorted_t[0].end; // first row for default max value -> [0] 300
            for (int i = 1; i < sorted_t.Count; i++)
            {
                // if begin <= max -> should compare the max by Math.Max(max, end)
                // Otherwise, the meeting time doesn't complict, start new min and max
                if (sorted_t[i].begin <= max)
                {
                    max = Math.Max(max, sorted_t[i].end);
                }
                else
                {
                    result.Add(new timetable() { begin = min, end = max, title = "" });
                    min = sorted_t[i].begin;
                    max = sorted_t[i].end;
                }
            }
            // add the final result
            result.Add(new timetable() { begin = min, end = max, title = "" });

            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----List Busy Timetable-----");
            List<timetable> t = new List<timetable>();
            t.Add(new timetable() { begin = 250, end = 310, title = "meeting_01" });
            t.Add(new timetable() { begin = 200, end = 230, title = "meeting_02" });
            t.Add(new timetable() { begin = 100, end = 300, title = "meeting_03" });
            t.Add(new timetable() { begin = 500, end = 600, title = "meeting_04" });
            t.Add(new timetable() { begin = 600, end = 700, title = "meeting_05" });

            List<timetable> result = busy_time(t);
            foreach (var r in result)
            {
                Console.WriteLine(string.Format("{0}, {1}", r.begin, r.end));
            }
        }
    }
}