using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCSharp_Sort_Junction_Box
{
    /*
    I03_Sort Junction Box -> similar with 937_Reorder Data in Log Files
    2021/09/25
    
    Your task is to sort the junction boxes in the following order:
    1. The older junction boxes should be returned first, sorted by lexicographic ordering of alphabetic version.
    2. If there are any ties in the older generation ties should be broken by the alphanumeric identifier.
    3. The newer generation boxes must all come after the older generation in the original order they were given in the input.

    Examples
    Input:
    boxLst=
    [ykc 82 01]
    [eo first qpx]
    [09z cat hamster]
    [06f 12 25 6]
    [az0 first qpx]
    [236 cat dog rabbit snake]

    output:
    [236 cat dog rabbit snake]
    [09z cat hamster]
    [az0 first qpx]
    [eo first qpx]
    [ykc 82 01]
    [06f 12 25 6]
    */

    public class Sort_Junction_Box
    {
        // This apporach doesn't consider the same junction box id
        // Time complexity: O(n log n)
        // Space complexity: O(n)
        public static List<string> sortBoxes_1(List<string> boxList)
        {
            List<string> result = new List<string>();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (var i in boxList)
            {
                dic.Add(i.Substring(0, i.IndexOf(' ')), i.Substring(i.IndexOf(' ') + 1));
            }
            Dictionary<string, string> dic_contracted = new Dictionary<string, string>();
            Dictionary<string, string> dic_uncontracted = new Dictionary<string, string>();
            foreach (var d in dic)
            {
                if (d.Value.Any(x => char.IsDigit(x)))
                {
                    dic_contracted.Add(d.Key, d.Value);
                }
                else
                {
                    dic_uncontracted.Add(d.Key, d.Value);
                }
            }

            var sort_uncontracted = dic_uncontracted.OrderBy(x => x.Value).ThenBy(y => y.Key);

            foreach (var unc in sort_uncontracted)
            {
                result.Add(unc.Key + " " + unc.Value);
            }

            foreach (var c in dic_contracted)
            {
                result.Add(c.Key + " " + c.Value);
            }
            return result;
        }

        // Time complexity: O(n log n)
        // Space complexity: O(n)
        public static List<string> sortBoxes_2(List<string> boxList)
        {
            List<string> result = new List<string>();
            List<string> uncontracted = new List<string>();
            List<string> contracted = new List<string>();

            foreach (string s in boxList)
            {
                if (char.IsDigit(s[s.IndexOf(" ") + 1]))
                {
                    contracted.Add(s);
                }
                else
                {
                    uncontracted.Add(s);
                }
            }

            result = uncontracted.OrderBy(x => x.Substring(x.IndexOf(' ') + 1)).ThenBy(y => y.Substring(0, y.IndexOf(' '))).ToList(); 
            result.AddRange(contracted);

            return result;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            // List<string> boxList = new List<string>();
            // boxList.Add("ykc 82 01");
            // boxList.Add("eo first qpx");
            // boxList.Add("09z cat hamster");
            // boxList.Add("06f 12 25 6");
            // boxList.Add("az0 first qpx");
            // boxList.Add("236 cat dog rabbit snake");
            // sortBoxes_1(boxList);

            List<string> boxList = new List<string>();
            boxList.Add("ykc 82 01");
            boxList.Add("06f aaa"); //
            boxList.Add("eo first qpx");
            boxList.Add("09z cat hamster");
            boxList.Add("09z zzz"); // add for testing the same id
            boxList.Add("06f 12 25 6");
            boxList.Add("az0 first qpx");
            boxList.Add("236 cat dog rabbit snake");
            boxList.Add("06f 123"); //
            boxList.Add("06f 123"); //
            boxList.Add("06f aaa"); //
            Console.WriteLine(string.Join(", ", sortBoxes_2(boxList).ToArray()));
        }
    }
}