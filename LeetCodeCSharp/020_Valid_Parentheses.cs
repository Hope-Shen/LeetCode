using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeCSharp_Valid_Parentheses
{
    /*
    020_Valid_Parentheses
    2021/08/09

    Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    An input string is valid if:
    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
     
    Example 1:
    Input: s = "()"
    Output: true
    
    Example 2:
    Input: s = "()[]{}"
    Output: true
    
    Example 3:
    Input: s = "(]"
    Output: false
    
    Example 4:
    Input: s = "([)]"
    Output: false
    
    Example 5:
    Input: s = "{[]}"
    Output: true
    */
    public class Valid_Parentheses
    {
        // Time complexity: O(n)
        // Space complexity: O(n))
        public static bool IsValid(string s)
        {
            if (s.Length <= 1) return false;
            Dictionary<char, char> dic = new Dictionary<char, char>();
            dic.Add('(', ')');
            dic.Add('[', ']');
            dic.Add('{', '}');

            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    st.Push(dic[s[i]]);
                    continue;
                }

                if (st.Count != 0 && st.Peek() == s[i])
                {
                    st.Pop();
                }
                else
                {
                    return false;
                }
            }
            return st.Count == 0 ? true : false;
        }

        // run code should change this function name with Main instead of fun_Main
        static void fun_Main(string[] args)
        {
            Console.WriteLine("-----Valid Parentheses-----");
            Console.WriteLine(IsValid("()"));
            Console.WriteLine(IsValid("()[]{}"));
            Console.WriteLine(IsValid("{[]}"));
            Console.WriteLine(IsValid("{()()}"));
            Console.WriteLine(IsValid("{()())}"));
            Console.WriteLine(IsValid("(]"));
            Console.WriteLine(IsValid("["));
            Console.WriteLine(IsValid("){"));
            Console.WriteLine(IsValid("(("));
            Console.WriteLine(IsValid("([)]"));
        }
    }
}