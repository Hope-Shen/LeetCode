package org.example.problem;

import java.util.*;


public class _268_Missing_Number {
    /*
    Date: 2025-01-02
    268_Missing_Number

    Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.

    Example 1:
    Input: nums = [3,0,1]
    Output: 2
    Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3].
    2 is the missing number in the range since it does not appear in nums.

    Example 2:
    Input: nums = [0,1]
    Output: 2
    Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2].
    2 is the missing number in the range since it does not appear in nums.

    Example 3:
    Input: nums = [9,6,4,2,3,5,7,0,1]
    Output: 8
    Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9].
    8 is the missing number in the range since it does not appear in nums.

    */
    public void missingNumber(){
        System.out.println("##### 268_Missing_Number #####");
        // solution 1
        System.out.println("solution 1");
        int result = missingNumber_1(new int[] {3, 0, 1});
        System.out.println("2 - " + result);

        result = missingNumber_1(new int[] {0, 1});
        System.out.println("2 - " + result);

        result = missingNumber_1(new int[] {9, 6, 4, 2, 3, 5, 7, 0, 1});
        System.out.println("8 - " + result);

        // solution 2
        System.out.println("solution 2");
        result = missingNumber_2(new int[] {3, 0, 1});
        System.out.println("2 - " + result);

        result = missingNumber_2(new int[] {0, 1});
        System.out.println("2 - " + result);

        result = missingNumber_2(new int[] {9, 6, 4, 2, 3, 5, 7, 0, 1});
        System.out.println("8 - " + result);

        // solution 3
        System.out.println("solution 3");
        result = missingNumber_3(new int[] {3, 0, 1});
        System.out.println("2 - " + result);

        result = missingNumber_3(new int[] {0, 1});
        System.out.println("2 - " + result);

        result = missingNumber_3(new int[] {9, 6, 4, 2, 3, 5, 7, 0, 1});
        System.out.println("8 - " + result);

        // solution 4
        System.out.println("solution 4");
        result = missingNumber_4(new int[] {3, 0, 1});
        System.out.println("2 - " + result);

        result = missingNumber_4(new int[] {0, 1});
        System.out.println("2 - " + result);

        result = missingNumber_4(new int[] {9, 6, 4, 2, 3, 5, 7, 0, 1});
        System.out.println("8 - " + result);
    }
    protected int missingNumber_1(int[] nums) {
        // Time complexity: O(n log n)
        // Space complexity: O(1)
        Arrays.sort(nums);
        for(int i = 0; i < nums.length; i ++){
            if(i != nums[i]){
                return i;
            }
        }
        return nums.length;
    }

    protected int missingNumber_2(int[] nums) {
        // Time complexity: O(n)
        // Space complexity: O(n)
        HashSet<Integer> set = new HashSet<>();

        for (int num : nums) {
            set.add(num);
        }

        for (int i = 0; i <= nums.length; i++) {
            if (!set.contains(i)) {
                return i;
            }
        }

        return -1;
    }

    protected int missingNumber_3(int[] nums) {
        // Time complexity: O(n)
        // Space complexity: O(1)

        // sum of array n * (n+1) / 2
        int n = nums.length;
        int totalSum = n * (n+1) / 2;
        int actualSum = 0;

        for (int num : nums) {
            actualSum += num;
        }
        return totalSum - actualSum;
    }

    protected int missingNumber_4(int[] nums) {
        // Time complexity: O(n)
        // Space complexity: O(1)

        int xor = 0, n = nums.length;

        // XOR
        for (int i = 0; i < n; i++) {
            // System.out.println(xor);
            xor ^= i ^ nums[i];
        }

        return xor ^ n; // last xor XOR n
    }

    //    XOR
    // [ 3, 0, 1, 4 ]
    // n = 4 -> 0100

    //xor = 0

    // Round1 -> i = 0,  num[i] = 3 ->  0 ^ 3
    // i ^ nums[i] -> 0 ^ 3 -> 000 ^ 011
    // 000
    // 011
    // ----
    // 011
    // xor = xor ^ 011
    // 000
    // 011
    // ----
    // 011 -> new xor

    // Round2 -> i = 1, num[i] = 0
    // i ^ nums[i] -> 1 ^ 0 -> 001 ^ 000
    // 001
    // 000
    // -----
    // 001
    // xor = xor ^ 001 -> Round 1 xor = 011, 011 ^ 001
    // 011
    // 001
    // -----
    // 010 -> new xor

    // Round3 -> i = 2, nums[i] = 1
    // i ^ nums[i] -> 2 ^ 1 -> 010 ^ 001
    // 010
    // 001
    // ---
    // 011
    // xor = xor ^ 011 -> Round 2 xor = 010, 010 ^ 011
    // 010
    // 011
    // ----
    // 001 -> new xor

    // Round4 -> i = 3, nums[i] = 4
    // i ^ nums[i] -> 3 ^ 4 -> 011 ^ 100
    // 011
    // 100
    // ---
    // 111
    // xor = xor ^ 111-> Round 3 xor = 001, 001 ^ 111
    // 001
    // 111
    // ----
    // 110 -> new xor

    // final -> xor ^ n -> 110 ^ 100
    // 110
    // 100
    // ----
    // 010 -> 2
}
