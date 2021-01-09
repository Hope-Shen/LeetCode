# encoding: utf-8

# 001_Two_Sum
# 2021/01/05
#
# Given an array of integers nums and an integer target, return indices of the two numbers such
# that they add up to target.
# Example 1:
# Input: nums = [2,7,11,15], target = 9
# Output: [0,1]
# Output: Because nums[0] + nums[1] == 9, we return [0, 1].
#
# Example 2:
# Input: nums = [3,2,4], target = 6
# Output: [1,2]
#
# Example 3:
# Input: nums = [3,3], target = 6
# Output: [0,1]

class Solution:
    # 暴力解法 O(n^2)
    def twoSum(self, nums, target):
        for x in range(len(nums)):
            for y in range(x + 1, len(nums)):
                if nums[x] + nums[y] == target:
                    return[x, y]
        return []

    # Hash O(1) by 力扣
    # 这样我们创建一个哈希表，对于每一个 x，我们首先查询哈希表中是否存在 target - x，
    # 然后将 x 插入到哈希表中，即可保证不会让 x 和自己匹配。
    def twoSumHash(self, nums, target):
        hashtable = dict()
        for i, num in enumerate(nums):
            if target - num in hashtable:
                return [hashtable[target - num], i]
            hashtable[nums[i]] = i
        return []


if __name__ == '__main__':
    # begin
    s = Solution()
    print(s.twoSum([2,7,11,15], 9))
    print(s.twoSum([3, 2, 4], 6))
    print(s.twoSum([3, 3], 6))
    print("----------")
    print(s.twoSumHash([2,7,11,15], 9))
    print(s.twoSumHash([3, 2, 4], 6))
    print(s.twoSumHash([3, 3], 6))
