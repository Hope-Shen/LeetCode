using System;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCodeCSharp_Valid_Palindrome
{
    /*
    125_Valid_Palindrome
    2021/06/12

    Given a string s, determine if it is a palindrome, 
    considering only alphanumeric characters and ignoring cases.

    Example 1:
    Input: s = "A man, a plan, a canal: Panama"
    Output: true
    Explanation: "amanaplanacanalpanama" is a palindrome.

    Example 2:
    Input: s = "race a car"
    Output: false
    Explanation: "raceacar" is not a palindrome.
    
    Constraints:
    1 <= s.length <= 2 * 105
    s consists only of printable ASCII characters.
    */

    class Valid_Palindrome
    {
        // Time complexity: O(n)
        // Space complexity: O(n)
        public static bool IsPalindrome_1(string s)
        {
            var newStr = new StringBuilder();
            foreach (char c in s.ToUpper())
            {
                if (char.IsLetterOrDigit(c))
                {
                    newStr.Append(c);
                }
            }

            var newStr_filtered = new StringBuilder();
            for (int i = newStr.ToString().Length - 1; i >= 0; i--)
            {
                newStr_filtered.Append(newStr[i]);
            }

            return newStr.ToString().Equals(newStr_filtered.ToString()) ? true : false;
        }

        // Time complexity: O(n)
        // Space complexity: O(n)
        public static bool IsPalindrome_2(string s)
        {
            var newStr = new StringBuilder();
            foreach (char c in s.ToUpper())
            {
                if (char.IsLetterOrDigit(c))
                {
                    newStr.Append(c);
                }
            }

            char[] newChar = newStr.ToString().ToCharArray();
            Array.Reverse(newChar);
            return newStr.ToString().Equals(new string(newChar)) ? true : false;
        }

        // Two pointer
        // Time complexity: O(n)
        // Space complexity: O(1)
        public static bool IsPalindrome_3(string s)
        {
            string newStr = Regex.Replace(s, "[^A-Za-z0-9]", "").ToUpper();
            // var newStr = new StringBuilder();
            // foreach(char c in s.ToUpper())
            // {
            //     if(char.IsLetterOrDigit(c))
            //     {
            //         newStr.Append(c);
            //     }
            // }

            int left = 0, right = newStr.Length - 1;
            while (left < right)
            {
                if (newStr[left] == newStr[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----IsPalindrome_1-----");
            Console.WriteLine(IsPalindrome_1("A man, a plan, a canal: Panama"));
            Console.WriteLine(IsPalindrome_1("race a car"));
            Console.WriteLine(IsPalindrome_1("0P"));
            Console.WriteLine(IsPalindrome_1("TAAeAAT"));
            Console.WriteLine("-----IsPalindrome_2-----");
            Console.WriteLine(IsPalindrome_2("A man, a plan, a canal: Panama"));
            Console.WriteLine(IsPalindrome_2("race a car"));
            Console.WriteLine(IsPalindrome_2("0P"));
            Console.WriteLine(IsPalindrome_2("TAAeAAT"));
            Console.WriteLine("-----IsPalindrome_3-----");
            Console.WriteLine(IsPalindrome_3("A man, a plan, a canal: Panama"));
            Console.WriteLine(IsPalindrome_3("race a car"));
            Console.WriteLine(IsPalindrome_3("0P"));
            Console.WriteLine(IsPalindrome_3("TAAeAAT"));
        }
    }
}
