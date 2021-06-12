# encoding: utf-8

# Wrong answer for here, please check c# verisons
# s
# 021_Merge_Two_Lists
# 2021/05/13
#
# Merge two sorted linked lists and return it as a sorted list. 
# The list should be made by splicing together the nodes of the first two lists.

# Example 1:
# Input: l1 = [1,2,4], l2 = [1,3,4]
# Output: [1,1,2,3,4,4]

# Example 2:
# Input: l1 = [], l2 = []
# Output: []

# Example 3:
# Input: l1 = [], l2 = [0]
# Output: [0]
 
# Constraints:
# The number of nodes in both lists is in the range [0, 50].
# -100 <= Node.val <= 100
# Both l1 and l2 are sorted in non-decreasing order.

class Solution:
    def mergeTwoLists_1(self, l1, l2):
        link = l1 + l2
        link.sort()
        return link
    
    def mergeTwoLists_2(self, l1, l2):
        result = list()
        l1_count, l2_count = len(l1), len(l2)
        i, j= 0, 0

        for x in range(l1_count + l2_count):
            if l1_count == i and l2_count >= j:
                result.append(l2[j])
                j+=1
            elif l1_count >= i and l2_count == j:
                result.append(l1[i])
                i+=1
            else:
                if l1[i] <= l2[j]:
                    result.append(l1[i])
                    i+=1
                else:
                    result.append(l2[j])
                    j+=1

        return result


if __name__ == '__main__':
    # begin
    s = Solution()
    print("=====mergeTwoLists_1=====")
    l1_1 = [1,2,4]
    l1_2 = [1,3,4]
    print("l1:", s.mergeTwoLists_1(l1_1, l1_2))
    l2_1 = []
    l2_2 = []
    print("l2:", s.mergeTwoLists_1(l2_1, l2_2))
    l3_1 = []
    l3_2 = [0]
    print("l3:", s.mergeTwoLists_1(l3_1, l3_2))
    print("=====mergeTwoLists_2=====")
    l1_1 = [1,2,4]
    l1_2 = [1,3,4]
    print("l1:", s.mergeTwoLists_2(l1_1, l1_2))
    l2_1 = []
    l2_2 = []
    print("l2:", s.mergeTwoLists_2(l2_1, l2_2))
    l3_1 = []
    l3_2 = [0]
    print("l3:", s.mergeTwoLists_2(l3_1, l3_2))