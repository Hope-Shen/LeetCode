package org.example.problem;

import org.junit.jupiter.api.Test;

import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.*;

class _001_Two_SumTest {
    _001_Two_Sum twoSumSolver = new _001_Two_Sum();
    @Test
    void twoSum_1() {
        // Test case 1:
        int[] num1 = {2, 7, 11, 15};
        int targat1 = 9;
        int[] expected1 = {0, 1};
        int[] result1 = twoSumSolver.twoSum_1(num1, targat1);
        System.out.println("Input: nums=" + Arrays.toString(num1) + " and target=" + targat1 + ", Output: " + Arrays.toString(result1));
        assertArrayEquals(expected1, result1, "Expected: " + Arrays.toString(expected1) +", Actual: " + Arrays.toString(expected1));

        // Test case 2:
        int[] num2 = {3, 2, 4};
        int targat2 = 6;
        int[] expected2 = {1, 2};
        int[] result2 = twoSumSolver.twoSum_1(num2, targat2);
        System.out.println("Input: nums=" + Arrays.toString(num2) + " and target=" + targat2 + ", Output: " + Arrays.toString(result2));
        assertArrayEquals(expected2, result2,  "Expected: " + Arrays.toString(expected2) +", Actual: " + Arrays.toString(expected2));

        // Test case 3:
        int[] num3 = {3, 3};
        int targat3 = 6;
        int[] expected3 = {0, 1};
        int[] result3 = twoSumSolver.twoSum_1(num3, targat3);
        System.out.println("Input: nums=" + Arrays.toString(num3) + " and target=" + targat3 + ", Output: " + Arrays.toString(result3));
        assertArrayEquals(expected3, result3,  "Expected: " + Arrays.toString(expected3) +", Actual: " + Arrays.toString(expected3));
    }

    @Test
    void twoSum_2() {
        // Test case 1:
        int[] num1 = {2, 7, 11, 15};
        int targat1 = 9;
        int[] expected1 = {0, 1};
        int[] result1 = twoSumSolver.twoSum_2(num1, targat1);
        System.out.println("Input: nums=" + Arrays.toString(num1) + " and target=" + targat1 + ", Output: " + Arrays.toString(result1));
        assertArrayEquals(expected1, result1, "Expected: " + Arrays.toString(expected1) +", Actual: " + Arrays.toString(expected1));

        // Test case 2:
        int[] num2 = {3, 2, 4};
        int targat2 = 6;
        int[] expected2 = {1, 2};
        int[] result2 = twoSumSolver.twoSum_2(num2, targat2);
        System.out.println("Input: nums=" + Arrays.toString(num2) + " and target=" + targat2 + ", Output: " + Arrays.toString(result2));
        assertArrayEquals(expected2, result2,  "Expected: " + Arrays.toString(expected2) +", Actual: " + Arrays.toString(expected2));

        // Test case 3:
        int[] num3 = {3, 3};
        int targat3 = 6;
        int[] expected3 = {0, 1};
        int[] result3 = twoSumSolver.twoSum_2(num3, targat3);
        System.out.println("Input: nums=" + Arrays.toString(num3) + " and target=" + targat3 + ", Output: " + Arrays.toString(result3));
        assertArrayEquals(expected3, result3,  "Expected: " + Arrays.toString(expected3) +", Actual: " + Arrays.toString(expected3));
    }
}