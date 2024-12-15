package org.example.problem;

import java.util.HashMap;
import java.util.Map;

public class _001_Two_Sum {
    /*
    Date: 2023-08-12
    001_Two_Sum

    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.

    Example 1:
    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Output: Because nums[0] + nums[1] == 9, we return [0, 1].

    Example 2:
    Input: nums = [3,2,4], target = 6
    Output: [1,2]

    Example 3:
    Input: nums = [3,3], target = 6
    Output: [0,1]
    */
    public void twoSum(){
        System.out.println("##### 001_Two_Sum #####");
        // solution 1
        System.out.println("solution 1");
        int[] result = twoSum_1(new int[] {2,7,11,15}, 9);
        System.out.println(result[0] + " " + result[1]);

        result = twoSum_1(new int[] {3, 2, 4}, 6);
        System.out.println(result[0] + " " + result[1]);

        result = twoSum_1(new int[] {3, 3}, 6);
        System.out.println(result[0] + " " + result[1]);

        result = twoSum_1(new int[] {2, 5, 5, 11}, 10);
        System.out.println(result[0] + " " + result[1]);

        // solution 2
        System.out.println("solution 2 - Better solution");

        int[] result2 = twoSum_2(new int[] {2,7,11,15}, 9);
        System.out.println(result[0] + " " + result2[1]);

        result2 = twoSum_2(new int[] {3, 2, 4}, 6);
        System.out.println(result2[0] + " " + result2[1]);

        result2 = twoSum_2(new int[] {3, 3}, 6);
        System.out.println(result2[0] + " " + result2[1]);

        result2 = twoSum_2(new int[] {2, 5, 5, 11}, 10);
        System.out.println(result2[0] + " " + result2[1]);
    }

    protected int[] twoSum_1(int[] nums, int target) {
        // Brute force
        // Time complexity: O(n^2)
        // Space complexity: O(1)
        for (int i = 0; i < nums.length; i++) {
            for (int j =1; j< nums.length; j++) {
                if (nums[i] + nums[j] == target && i != j) {
                    return new int[] {i,j};
                }
            }
        }
        return null;
    }

    protected int[] twoSum_2(int[] nums, int target) {
        // HashMap
        // Time complexity: O(n)
        // Space complexity: O(n)
        Map<Integer, Integer> map = new HashMap<>();
        for (int i =0; i< nums.length; i++) {
            if(map.containsKey(target - nums[i])){
                return new int[] {map.get(target - nums[i]), i};
            }
            map.put(nums[i], i);
        }
        return null;
    }
}
