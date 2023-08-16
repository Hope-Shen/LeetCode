package org.example.problem;

import java.util.HashMap;
import java.util.LinkedList;
import java.util.Map;

public class _020_Valid_Parentheses {
    /*
    Date: 2023-08-12
    020_Valid_Parentheses

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

    Example 6:
    Input: s = "]"
    Output: false

    Example 7:
    Input: s = "){"
    Output: false

    Example 8:
    Input: s = "))"
    Output: false

    */
    public void validParentheses(){
        System.out.println("##### 020_Valid_Parentheses #####");
        // solution 1
        System.out.println("solution 1");
        boolean result = validParentheses_1("()");
        System.out.println("true - " + result);

        result = validParentheses_1("()[]{}");
        System.out.println("true - " + result);

        result = validParentheses_1("(]");
        System.out.println("false - " + result);

        result = validParentheses_1("([)]");
        System.out.println("false - " + result);

        result = validParentheses_1("{[]}");
        System.out.println("true - " + result);

        result = validParentheses_1("]");
        System.out.println("false - " + result);

        result = validParentheses_1("){");
        System.out.println("false - " + result);

        result = validParentheses_1("))");
        System.out.println("false - " + result);
    }
    private boolean validParentheses_1(String s) {
        // Time complexity: O(n)
        // Space complexity: O(n)
        if (s.length() <= 1) return false;

        Map<Character, Character> map = new HashMap<>();
        map.put('(', ')');
        map.put('{', '}');
        map.put('[', ']');

        LinkedList<Character> stack = new LinkedList<>();
        for (int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if(map.containsKey(c)) {
                stack.push(map.get(c));
                continue;
            }
            if(stack.size() != 0 && stack.peek().equals(c)) {
                stack.pop();
            }else{
                return false;
            }
        }
        return stack.size() == 0 ? true : false;
    }
}
