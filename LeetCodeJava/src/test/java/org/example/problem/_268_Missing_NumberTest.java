package org.example.problem;
import org.junit.jupiter.api.Test;
import java.util.Arrays;
import static org.junit.jupiter.api.Assertions.assertEquals;

class _268_Missing_NumberTest {
    _268_Missing_Number missingNumberSolver = new _268_Missing_Number();
    @Test
    void missingNumber_1() {
        // Test case 1:
        int[] num1 = {3, 0, 1};
        int expected1 = 2;
        int result1 = missingNumberSolver.missingNumber_1(num1);
        System.out.println("Input: nums=" + Arrays.toString(num1) + ", Output: " + result1);
        assertEquals(expected1, result1, "Expected: " + expected1 +", Actual: " + expected1);

        // Test case 2:
        int[] num2 = {0, 1};
        int expected2 = 2;
        int result2 = missingNumberSolver.missingNumber_1(num2);
        System.out.println("Input: nums=" + Arrays.toString(num2) + ", Output: " + result2);
        assertEquals(expected2, result2, "Expected: " + expected2 +", Actual: " + expected2);

        // Test case 3:
        int[] num3 = {9, 6, 4, 2, 3, 5, 7, 0, 1};
        int expected3 = 8;
        int result3 = missingNumberSolver.missingNumber_1(num3);
        System.out.println("Input: nums=" + Arrays.toString(num3) + ", Output: " + result3);
        assertEquals(expected3, result3, "Expected: " + expected3 +", Actual: " + expected3);
    }

    @Test
    void missingNumber_2() {
        // Test case 1:
        int[] num1 = {3, 0, 1};
        int expected1 = 2;
        int result1 = missingNumberSolver.missingNumber_2(num1);
        System.out.println("Input: nums=" + Arrays.toString(num1) + ", Output: " + result1);
        assertEquals(expected1, result1, "Expected: " + expected1 +", Actual: " + expected1);

        // Test case 2:
        int[] num2 = {0, 1};
        int expected2 = 2;
        int result2 = missingNumberSolver.missingNumber_2(num2);
        System.out.println("Input: nums=" + Arrays.toString(num2) + ", Output: " + result2);
        assertEquals(expected2, result2, "Expected: " + expected2 +", Actual: " + expected2);

        // Test case 3:
        int[] num3 = {9, 6, 4, 2, 3, 5, 7, 0, 1};
        int expected3 = 8;
        int result3 = missingNumberSolver.missingNumber_2(num3);
        System.out.println("Input: nums=" + Arrays.toString(num3) + ", Output: " + result3);
        assertEquals(expected3, result3, "Expected: " + expected3 +", Actual: " + expected3);
    }

    @Test
    void missingNumber_3() {
        // Test case 1:
        int[] num1 = {3, 0, 1};
        int expected1 = 2;
        int result1 = missingNumberSolver.missingNumber_3(num1);
        System.out.println("Input: nums=" + Arrays.toString(num1) + ", Output: " + result1);
        assertEquals(expected1, result1, "Expected: " + expected1 +", Actual: " + expected1);

        // Test case 2:
        int[] num2 = {0, 1};
        int expected2 = 2;
        int result2 = missingNumberSolver.missingNumber_3(num2);
        System.out.println("Input: nums=" + Arrays.toString(num2) + ", Output: " + result2);
        assertEquals(expected2, result2, "Expected: " + expected2 +", Actual: " + expected2);

        // Test case 3:
        int[] num3 = {9, 6, 4, 2, 3, 5, 7, 0, 1};
        int expected3 = 8;
        int result3 = missingNumberSolver.missingNumber_3(num3);
        System.out.println("Input: nums=" + Arrays.toString(num3) + ", Output: " + result3);
        assertEquals(expected3, result3, "Expected: " + expected3 +", Actual: " + expected3);
    }

    @Test
    void missingNumber_4() {
        // Test case 1:
        int[] num1 = {3, 0, 1};
        int expected1 = 2;
        int result1 = missingNumberSolver.missingNumber_4(num1);
        System.out.println("Input: nums=" + Arrays.toString(num1) + ", Output: " + result1);
        assertEquals(expected1, result1, "Expected: " + expected1 +", Actual: " + expected1);

        // Test case 2:
        int[] num2 = {0, 1};
        int expected2 = 2;
        int result2 = missingNumberSolver.missingNumber_4(num2);
        System.out.println("Input: nums=" + Arrays.toString(num2) + ", Output: " + result2);
        assertEquals(expected2, result2, "Expected: " + expected2 +", Actual: " + expected2);

        // Test case 3:
        int[] num3 = {9, 6, 4, 2, 3, 5, 7, 0, 1};
        int expected3 = 8;
        int result3 = missingNumberSolver.missingNumber_4(num3);
        System.out.println("Input: nums=" + Arrays.toString(num3) + ", Output: " + result3);
        assertEquals(expected3, result3, "Expected: " + expected3 +", Actual: " + expected3);
    }
}