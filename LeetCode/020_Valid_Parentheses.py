# encoding: utf-8

# 020_Valid_Parentheses
# 2021/05/12
#
# Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
# determine if the input string is valid.

# An input string is valid if:
# Open brackets must be closed by the same type of brackets.
# Open brackets must be closed in the correct order.
 
# Example 1:
# Input: s = "()"
# Output: true

# Example 2:
# Input: s = "()[]{}"
# Output: true

# Example 3:
# Input: s = "(]"
# Output: false

# Example 4:
# Input: s = "([)]"
# Output: false

# Example 5:
# Input: s = "{[]}"
# Output: true
 
# Constraints:
# 1 <= s.length <= 104
# s consists of parentheses only '()[]{}'.

class Solution:
    '''My result'''
    def isValidParentheses_1(self, strs):
        strs_list = list(strs)
        temp_list = list()
        dit = {'{':'}', '[':']','(':')'}
        
        for i in strs_list:
            if i in dit:
                temp_list.append(dit[i])
            elif len(temp_list)!=0 and i in temp_list[-1]:
                temp_list.pop()
            else:
                return False
        
        if len(temp_list)!=0:
            return False
        
        return True

    '''Result from Leetcode solution (Better than mind) '''   
    def isValidParentheses_2(self, strs):
        dit = {')':'(',']':'[','}':'{'}
        stack = list()
        for i in strs:
            if stack and i in dit:
                if stack[-1] == dit[i]: 
                    stack.pop()
                else: 
                    return False
            else: 
                stack.append(i)
            
        return not stack


if __name__ == '__main__':
    # begin
    s = Solution()
    print("=====isValidParentheses_1=====")
    print("-----True-----")
    str1 = "()"
    print("str1:", s.isValidParentheses_1(str1))
    str2 = "()[]{}"
    print("str2:", s.isValidParentheses_1(str2))
    str3 = "{[]}"
    print("str3:", s.isValidParentheses_1(str3))
    str4 = "{[][()()]}"
    print("str4:", s.isValidParentheses_1(str4))
    print("-----False-----")
    str5 = "(]"
    print("str5:", s.isValidParentheses_1(str5))
    str6 = "([)]"
    print("str6:", s.isValidParentheses_1(str6))
    str7 = "{()())}"
    print("str7:", s.isValidParentheses_1(str7))
    str8 = "["
    print("str8:", s.isValidParentheses_1(str8))
    str9 = "{["
    print("str9:", s.isValidParentheses_1(str9))
    str10 = "){"
    print("str10:", s.isValidParentheses_1(str10))
    print("")
    print("=====isValidParentheses_2=====")
    print("-----True-----")
    str1 = "()"
    print("str1:", s.isValidParentheses_2(str1))
    str2 = "()[]{}"
    print("str2:", s.isValidParentheses_2(str2))
    str3 = "{[]}"
    print("str3:", s.isValidParentheses_2(str3))
    str4 = "{[][()()]}"
    print("str4:", s.isValidParentheses_2(str4))
    print("-----False-----")
    str5 = "(]"
    print("str5:", s.isValidParentheses_2(str5))
    str6 = "([)]"
    print("str6:", s.isValidParentheses_2(str6))
    str7 = "{()())}"
    print("str7:", s.isValidParentheses_2(str7))
    str8 = "["
    print("str8:", s.isValidParentheses_2(str8))
    str9 = "{["
    print("str9:", s.isValidParentheses_2(str9))
    str10 = "){"
    print("str10:", s.isValidParentheses_2(str10))