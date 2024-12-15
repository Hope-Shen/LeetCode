package org.example.problem;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class _01_01_Is_UniqueTest {

    @Test
    void testIsUnique_1() {
        _01_01_Is_Unique solution = new _01_01_Is_Unique();

        // Test case 1:
        String input1 = "leetcode";
        boolean result1 = solution.isUnique_1(input1);
        System.out.println("Input: " + input1 + ", Output: " + result1);
        assertFalse(result1, "Input: " + input1 + ", Expected: false, Actual: " + result1);

        // Test case 2:
        String input2 = "abc";
        boolean result2 = solution.isUnique_1(input2);
        System.out.println("Input: " + input2 + ", Output: " + result2);
        assertTrue(result2, "Input: " + input2 + ", Expected: true, Actual: " + result2);

        // Test case 3:
        String input3 = "";
        boolean result3 = solution.isUnique_1(input3);
        System.out.println("Input: " + input3 + ", Output: " + result3);
        assertTrue(result3, "Input: " + input3 + ", Expected: true, Actual: " + result3);
    }

    @Test
    void testIsUnique_2() {
        _01_01_Is_Unique solution = new _01_01_Is_Unique();

        // Test case 1:
        String input1 = "leetcode";
        boolean result1 = solution.isUnique_2(input1);
        System.out.println("Input: " + input1 + ", Output: " + result1);
        assertFalse(result1, "Input: " + input1 + ", Expected: false, Actual: " + result1);

        // Test case 2:
        String input2 = "abc";
        boolean result2 = solution.isUnique_2(input2);
        System.out.println("Input: " + input2 + ", Output: " + result2);
        assertTrue(result2, "Input: " + input2 + ", Expected: true, Actual: " + result2);

        // Test case 3:
        String input3 = "";
        boolean result3 = solution.isUnique_2(input3);
        System.out.println("Input: " + input3 + ", Output: " + result3);
        assertTrue(result3, "Input: " + input3 + ", Expected: true, Actual: " + result3);
    }

    @Test
    void testIsUnique_3() {
        _01_01_Is_Unique solution = new _01_01_Is_Unique();

        // Test case 1:
        String input1 = "leetcode";
        boolean result1 = solution.isUnique_3(input1);
        System.out.println("Input: " + input1 + ", Output: " + result1);
        assertFalse(result1, "Input: " + input1 + ", Expected: false, Actual: " + result1);

        // Test case 2:
        String input2 = "abc";
        boolean result2 = solution.isUnique_3(input2);
        System.out.println("Input: " + input2 + ", Output: " + result2);
        assertTrue(result2, "Input: " + input2 + ", Expected: true, Actual: " + result2);

        // Test case 3:
        String input3 = "";
        boolean result3 = solution.isUnique_3(input3);
        System.out.println("Input: " + input3 + ", Output: " + result3);
        assertTrue(result3, "Input: " + input3 + ", Expected: true, Actual: " + result3);
    }
}
