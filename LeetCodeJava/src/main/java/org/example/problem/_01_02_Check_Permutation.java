package org.example.problem;

import java.util.*;
import java.util.stream.Collectors;

public class _01_02_Check_Permutation {
    /*
    Date: 2023-08-14
    01_02_Check_Permutation

    Given two strings,write a method to decide if one is a permutation of the other.

    Example 1:
    Input: s1 = "abc", s2 = "bca"
    Output: true

    Example 2:
    Input: s1 = "abc", s2 = "bad"
    Output: false

    Example 3:
    Input: s1 = "a", s2 = "ab"
    Output: false

    Example 4:
    Input: s1 = "abb", s2 = "aab"
    Output: false

    */
    public void checkPermutation(){
        System.out.println("##### 01_02_Check_Permutation #####");
        // solution 1
        System.out.println("solution 1");
        boolean result = checkPermutation_1("abc", "bca");
        System.out.println("true - " + result);

        result = checkPermutation_1("abc", "bad");
        System.out.println("false - " + result);

        result = checkPermutation_1("a", "ab");
        System.out.println("false - " + result);

        result = checkPermutation_1("abb", "aab");
        System.out.println("false - " + result);

        // solution 2
        System.out.println("solution 2");
        result = checkPermutation_2("abc", "bca");
        System.out.println("true - " + result);

        result = checkPermutation_2("abc", "bad");
        System.out.println("false - " + result);

        result = checkPermutation_2("a", "ab");
        System.out.println("false - " + result);

        result = checkPermutation_2("abb", "aab");
        System.out.println("false - " + result);

        // solution 3
        System.out.println("solution 3");
        result = checkPermutation_3("abc", "bca");
        System.out.println("true - " + result);

        result = checkPermutation_3("abc", "bad");
        System.out.println("false - " + result);

        result = checkPermutation_3("a", "ab");
        System.out.println("false - " + result);

        result = checkPermutation_3("abb", "aab");
        System.out.println("false - " + result);
    }
    private boolean checkPermutation_1(String s1, String s2) {
        // Time complexity: O(n log n) for each sort, therefore two sort will be O( n long n + n) = O(n long n)
        // Space complexity: O(log n) for sort
        if(s1.length() != s2.length()) {
            return false;
        }

        char[] s1Array = s1.toCharArray();
        char[] s2Array = s2.toCharArray();

        Arrays.sort(s1Array);
        Arrays.sort(s2Array);
        if(Arrays.equals(s1Array, s2Array)) {
            return true;
        }
        return false;
    }

    private boolean checkPermutation_2(String s1, String s2) {
        // Time complexity: O(n) - for loop, hashMap is O(1)
        // Space complexity: O(n)
        if(s1.length() != s2.length()) {
            return false;
        }

        Map<Character, Integer> map = new HashMap<>();
        for(char i: s1.toCharArray()) {
            if(map.containsKey(i)) {
                map.put(i, map.get(i) + 1);
            } else {
                map.put(i, 1);
            }
        }
        for(char j: s2.toCharArray()) {
            if(map.containsKey(j)) {
                if(map.get(j) == 1) {
                    map.remove(j);
                } else {
                    map.put(j, map.get(j) - 1);
                }
            } else {
                return false;
            }
        }
        return map.size() > 0 ? false : true;
    }

    private boolean checkPermutation_3(String s1, String s2) {
        // Time complexity: O(n)
        // Space complexity: O(S) -> S = int[128]
        if(s1.length() != s2.length()) {
            return false;
        }
        int[] table = new int[128];
        for(int i = 0; i < s1.length(); i++) {
            table[s1.charAt(i)]++;
        }

        for(int j = 0; j < s2.length(); j++) {
            table[s2.charAt(j)]--;
            if(table[s2.charAt(j)] < 0) {
                return false;
            }
        }

        return true;
    }
}
