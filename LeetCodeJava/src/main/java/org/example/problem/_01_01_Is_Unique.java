package org.example.problem;

import java.util.HashMap;
import java.util.LinkedList;
import java.util.Map;

public class _01_01_Is_Unique {
    /*
    Date: 2023-08-12
    01_01_Is_Unique

    Implement an algorithm to determine if a string has all unique characters.
    What if you cannot use additional data structures?

    Example 1:
    Input: s = "leetcode"
    Output: false

    Example 2:
    Input: s = "abc"
    Output: true

    Example 3:
    Input: s = ""
    Output: true

    */
    public void isUnique(){
        System.out.println("##### 01_01_Is_Unique #####");
        // solution 1
        System.out.println("solution 1");
        boolean result = isUnique_1("leetcode");
        System.out.println("false - " + result);

        result = isUnique_1("abc");
        System.out.println("true - " + result);

        result = isUnique_1("");
        System.out.println("true - " + result);
    }
    private boolean isUnique_1(String s) {
        // Time complexity: O(n)
        // Space complexity: O(n)

        Map<Character, Character> map = new HashMap<>();
        for(int i=0; i<s.length(); i++){
            char c = s.charAt(i);

            if(map.containsKey(c)){
                return false;
            } else {
                map.put(c, c);
            }
        }
        return true;
    }
}
