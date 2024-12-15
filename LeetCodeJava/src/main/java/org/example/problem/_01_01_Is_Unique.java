package org.example.problem;

import java.util.*;

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

        // solution 2
        System.out.println("solution 2");
        boolean result2 = isUnique_2("leetcode");
        System.out.println("false - " + result2);

        result2 = isUnique_2("abc");
        System.out.println("true - " + result2);

        result2 = isUnique_2("");
        System.out.println("true - " + result2);

        // solution 3
        System.out.println("solution 3");
        boolean result3 = isUnique_3("leetcode");
        System.out.println("false - " + result3);

        result3 = isUnique_3("abc");
        System.out.println("true - " + result3);

        result3 = isUnique_3("");
        System.out.println("true - " + result3);
    }
    protected boolean isUnique_1(String s) {
        // HashMap -> use additional data structures
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

    protected boolean isUnique_2(String s) {
        // Sort -> no use additional data structures
        // Time complexity: O(n log n)
        // Space complexity: O(n)

        char[] chars = s.toCharArray();
        Arrays.sort(chars); // -> O(n log n)
        for(int i=0; i< chars.length-1; i++){ // -> O(n)
            if (chars[i] == chars[i+1]) {
                return false;
            }
        }
        return true;
    }

    protected boolean isUnique_3(String s) {
        // HashSet -> use additional data structures
        // Time complexity: O(n)
        // Space complexity: O(n)

        Set<Character> chars = new HashSet<>();
        for(char c: s.toCharArray()){
            if(chars.contains(c)) {
                return false;
            }
            chars.add(c);
        }
        return true;
    }
}
