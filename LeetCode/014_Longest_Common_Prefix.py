# encoding: utf-8

# 014_Longest_Common_Prefix
# 2021/05/12
#
# Write a function to find the longest common prefix string amongst an array of strings.
# 
# If there is no common prefix, return an empty string "".
# 
# Example 1:
# Input: strs = ["flower","flow","flight"]
# Output: "fl"
# 
# Example 2:
# Input: strs = ["dog","racecar","car"]
# Output: ""
# Explanation: There is no common prefix among the input strings.
#  
# Constraints:
# 1 <= strs.length <= 200
# 0 <= strs[i].length <= 200
# strs[i] consists of only lower-case English letters.

class Solution:
  '''
  Vertical scanning 縱向掃描法
  Time complexity: O(n+m)
  Space complexity: O(1)
  '''
  def prefix(self, strs):
    if not strs:
      return ""

    length, count = len(strs[0]), len(strs)
    for i in range(length):
      c = strs[0][i]
      for j in range(1, count):
        if i == len(strs[j]) or strs[j][i] != c :
            return strs[0][:i]

    return strs[0]


if __name__ == '__main__':
    # begin
    s = Solution()
    str1 = ["flower","flow","flight"]
    print("str1:", s.prefix(str1))
    str2 = ["dog","racecar","car"]
    print("str2:", s.prefix(str2))
    str3 = ["a"]
    print("str3:", s.prefix(str3))
    str4 = ["aa","aa","aaa"]
    print("str4:", s.prefix(str4))
    str5 = ["aa","aaa","a"]
    print("str5:", s.prefix(str5))
    str6 = ["cir","car"]
    print("str6:", s.prefix(str6))
    str7 = ["a","a","b"]
    print("str7:", s.prefix(str7))
    
