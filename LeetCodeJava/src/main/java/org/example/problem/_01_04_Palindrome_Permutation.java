package org.example.problem;

import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;

public class _01_04_Palindrome_Permutation {
    /*
    Date: 2023-08-15
    01_04_Palindrome_Permutation

    Given a string, write a function to check if it is a permutation of a palindrome.
    A palindrome is a word or phrase that is the same forwards and backwards.
    A permutation is a rearrangement of letters.
    The palindrome does not need to be limited to just dictionary words.

    Example 1:
    Input: "tactcoa"
    Output: true（permutations: "tacocat"、"atcocta", etc.）

    Example 2:
    Input: "banana"
    Output: false

    Example 3:
    Input: "aaaa"
    Output: false

    Example 4:
    Input: "aaa"
    Output: false

    Example 5:
    Input: "a"
    Output: true

    Example 6:
    Input: ""
    Output: true

    */
    public void palindromePermutation(){
        System.out.println("##### 01_04_Palindrome_Permutation #####");
        // solution 1
        System.out.println("solution 1");
        Boolean result = palindromePermutation_1("tactcoa");
        Boolean expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = palindromePermutation_1("banana");
        expectResult = false;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = palindromePermutation_1("aaaa");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = palindromePermutation_1("aaa");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = palindromePermutation_1("a");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = palindromePermutation_1("");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        // solution 2
        System.out.println("solution 2");
        result = palindromePermutation_2("tactcoa");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = palindromePermutation_2("banana");
        expectResult = false;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = palindromePermutation_2("aaaa");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = palindromePermutation_2("aaa");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = palindromePermutation_2("a");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));

        result = palindromePermutation_2("");
        expectResult = true;
        System.out.println(expectResult + " - " + result + " : " + result.equals(expectResult));
    }
    private boolean palindromePermutation_1(String s) {
        // Time complexity: O(n)
        // Space complexity: O(n)
        Map<Character, Integer> map = new HashMap<>();
        for(int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if(map.containsKey(c) && map.get(c) == 1) {
                map.remove(c);
            } else {
                map.put(c, 1);
            }
        }
        if(map.size() == 0 || map.size() == 1) {
            return true;
        } else {
            return false;
        }
    }

    private boolean palindromePermutation_2(String s) {
        // Time complexity: O(n)
        // Space complexity: O(n)
        Set<Character> set = new HashSet<>();
        for(int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if(set.contains(c)) {
                set.remove(c);
            } else {
                set.add(c);
            }
        }
        if(set.size() == 0 || set.size() == 1) {
            return true;
        } else {
            return false;
        }
    }
}
