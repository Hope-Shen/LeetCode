# encoding: utf-8

# 013_Roman_to_Integer
# 2021/01/09
#
# Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
#
# Symbol       Value
# I             1
# V             5
# X             10
# L             50
# C             100
# D             500
# M             1000
#
# For example, 2 is written as II in Roman numeral, just two one's added together.
# 12 is written as XII, which is simply X + II.
# The number 27 is written as XXVII, which is XX + V + II.
#
# Roman numerals are usually written largest to smallest from left to right.
# However, the numeral for four is not IIII. Instead, the number four is written as IV.
# Because the one is before the five we subtract it making four.
# The same principle applies to the number nine, which is written as IX.
# There are six instances where subtraction is used:
#
# I can be placed before V (5) and X (10) to make 4 and 9.
# X can be placed before L (50) and C (100) to make 40 and 90.
# C can be placed before D (500) and M (1000) to make 400 and 900.
# Given a roman numeral, convert it to an integer.
#
# Example 1:
# Input: s = "III"
# Output: 3
#
# Example 2:
# Input: s = "IV"
# Output: 4
#
# Example 3:
# Input: s = "IX"
# Output: 9
#
# Example 4:
# Input: s = "LVIII"
# Output: 58
# Explanation: L = 50, V= 5, III = 3.
#
# Example 5:
# Input: s = "MCMXCIV"
# Output: 1994
# Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
#
# Constraints:
# 1 <= s.length <= 15
# s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
# It is guaranteed that s is a valid roman numeral in the range [1, 3999].

class Solution:
    '''
    1. if left >= right then left + right
    2. if left < right then -left + right
    3. last number will always be possitive number

    we need to check left is greater or less than right so reverse input(roman number)
    initial first sum is the first(before reverse is the last number, like rule 3)
    ex:

    MCMXCIV --->(reverse) VICXMCM
    (initial => sum = (V) 5, pre = 5)
       pre  >  num                   sum
    1  5       1(I)     correct    5 - 1 = 4 (if correct then sum = sum - num)
    2  1       100(C)   wrong      4 + 100 = 104 (if wrong then sum = sum + num)
    3  100     10(X)    correct    104 - 10 = 94
    4  10      1000(M)  wrong      94 + 1000 = 1094
    5  1000    100(C)   correct    1094 - 100 = 994
    6  100     1000(M)  wrong      994 + 1000 = 1994
    '''
    def romanToInt(self, s):
        s_dic = {"I": 1, "V": 5, "X": 10, "L": 50, "C": 100, "D": 500, "M": 1000}

        s_reverse = s[::-1]
        pre = s_dic[s_reverse[0]]
        sum = pre
        for x in s_reverse[1: len(s_reverse)]:
            if pre > s_dic[x]:
                sum -= s_dic[x]
            else:
                sum +=s_dic[x]
            pre = s_dic[x]
        return sum

    '''
    跟方法一類似，不反轉數字，用pre 跟最後一個pre（因為永遠為正） 直做計算
    '''
    def romanToInt_2(self, s):
        s_dic = {"I": 1, "V": 5, "X": 10, "L": 50, "C": 100, "D": 500, "M": 1000}

        pre = s_dic[s[0]]
        sum = 0
        for x in range(1, len(s)):
            if pre >= s_dic[s[x]]:
                sum += pre
            else:
                sum -= pre
            pre = s_dic[s[x]]
        return sum + pre

    def romanToInt_3(self, s):
        s_dic = {"I": 1, "V": 5, "X": 10, "L": 50, "C": 100, "D": 500, "M": 1000, \
                "a": 4, "b": 9, "c": 40, "d": 90, "e": 400, "f": 900}

        s = s.replace("IV","a");
        s = s.replace("IX","b");
        s = s.replace("XL","c");
        s = s.replace("XC","d");
        s = s.replace("CD","e");
        s = s.replace("CM","f");

        sum = 0;
        for x in s:
            sum += s_dic[x]
        return sum

if __name__ == '__main__':
    # begin
    s = Solution()
    print("-----romanToInt-----")
    print(s.romanToInt("III"))
    print(s.romanToInt("IV"))
    print(s.romanToInt("IX"))
    print(s.romanToInt("LVIII"))
    print(s.romanToInt("MCMXCIV"))
    print("-----romanToInt_2-----")
    print(s.romanToInt_2("III"))
    print(s.romanToInt_2("IV"))
    print(s.romanToInt_2("IX"))
    print(s.romanToInt_2("LVIII"))
    print(s.romanToInt_2("MCMXCIV"))
    print("-----romanToInt_3-----")
    print(s.romanToInt_3("III"))
    print(s.romanToInt_3("IV"))
    print(s.romanToInt_3("IX"))
    print(s.romanToInt_3("LVIII"))
    print(s.romanToInt_3("MCMXCIV"))
