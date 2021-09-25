using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCSharp_Sort_Junction_Box
{
    /*
    I03_Sort Junction Box -> similar with 937_Reorder Data in Log Files
    2021/09/25

    Your team at XXXX has been contracted by a telecommunications company that is trying to upgrade junction boxes all over Techlandia. 
    Some of the junction boxes have already been upgraded, and other boxes have not. 
    Your task is to identify the oldest boxes that need to be upgraded first but leaving newer model boxes so that they will not be prioritized.
    All junction boxes are identified by an alphanumeric identifier, followed by space delimited version information. 
    The older generation uses space delimited lowercase English Strings to identify the version, 
    but the newer generation uses space delimited positive integers to identify the version. 
    
    Your task is to sort the junction boxes in the following order:
    1. The older junction boxes should be returned first, sorted by lexicographic ordering of alphabetic version.
    2. If there are any ties in the older generation ties should be broken by the alphanumeric identifier.
    3. The newer generation boxes must all come after the older generation in the original order they were given in the input.
    
    INPUT :
    The input to the function/method consists of one argument boxList, a list of strings representing all of the identifiers and version information.
    OUTPUT:
    Return a list of strings representing the correctly prioritized orders according to this system.
    
    Note:
    The Junction box identifier consists of only lowercase English characters and numbers. 
    Sorting for tiebreaks should use ASCII value - as a example, the order identifier 'a1' should come before the order identifier 'aa'.

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

    Explanation The four old generation junction boxes should come first, 
    with the "cat dog rabbit snake" box coming before the "cat hamster type". 
    Since the two boxes of type "first qpx" have the same version information, 
    they should come next, using the "azp" identifier to come before the "eo" identifier. 
    Finally the already upgraded junction boxes should come last in the origin order they were provided in the file
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