# encoding: utf-8

# 009_Palindrome_Number
# 2021/01/07
# ＊＊＊ 優化了 7_Reverse_integer 反轉計算 ＊＊＊
#
# Determine whether an integer is a palindrome.
# An integer is a palindrome when it reads the same backward as forward.
#
# Follow up: Could you solve it without converting the integer to a string?
#
# Example 1:
# Input: x = 121
# Output: true
#
# Example 2:
# Input: x = -121
# Output: false
# Explanation: From left to right, it reads -121. From right to left, it becomes 121-.
# Therefore it is not a palindrome.
#
# Example 3:
# Input: x = 10
# Output: false
# Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
#
# Example 4:
# Input: x = -101
# Output: false
#
# Constraints: -2^31 <= x <= 2^31 - 1


class Solution:
    '''
    negative and number < 10 will not be palindrome number

    ex: 1231

    1231 % 10 = 1
    1231 // 10 =123
    0 * 10 + 1 = 1

    123 % 10 = 3
    123 // 10 = 12
    1 * 10 + 3 = 13

    12 % 10 = 2
    12 // 10 = 1
    13 * 10 + 2 = 132

    1 % 10 = 1
    1 // 10 = 0
    132 * 10 + 1 = 1321
    '''
    def isPalindrome(self, x):
        reverse_x = 0
        org_x = x
        # x < 0 or 最后一位是 0 时，x 不是回文数，但是 0 可以是palindrome
        if x < 0 or (x % 10 == 0 and x != 0):
            return False

        while x > 0:
                reverse_x = reverse_x * 10 + x % 10
                x //= 10

        return True if reverse_x == org_x else False

    # 时间复杂度：O(logn)，对于每次迭代，我们会将输入除以 10，因此时间复杂度为 O(log n)。
    def isPalindrome_2(self, x):
        reverse_x = 0
        # x < 0 or 最后一位是 0 时，x 不是回文数，但是 0 可以是palindrome
        if x < 0 or (x % 10 == 0 and x != 0):
            return False

        while x > reverse_x:
            reverse_x = reverse_x * 10 + x % 10
            x //= 10

        return x == reverse_x or x == reverse_x // 10

    # 用string解
    def isPalindrome_3(self, x):
        if x < 0:
            return False

        return True if int(str(x)[::-1]) == x else False


if __name__ == '__main__':
    # begin
    s = Solution()
    print("-----isPalindrome-----")
    print(s.isPalindrome(121))
    print(s.isPalindrome(-121))
    print(s.isPalindrome(10))
    print(s.isPalindrome(-101))
    print(s.isPalindrome(1221))
    print(s.isPalindrome(1231))
    print(s.isPalindrome(0))
    print("-----isPalindrome_2-----")
    print(s.isPalindrome_2(121))
    print(s.isPalindrome_2(-121))
    print(s.isPalindrome_2(10))
    print(s.isPalindrome_2(-101))
    print(s.isPalindrome_2(1221))
    print(s.isPalindrome_2(1231))
    print(s.isPalindrome_2(0))
    print("-----isPalindrome_3-----")
    print(s.isPalindrome_3(121))
    print(s.isPalindrome_3(-121))
    print(s.isPalindrome_3(10))
    print(s.isPalindrome_3(-101))
    print(s.isPalindrome_3(1221))
    print(s.isPalindrome_3(1231))
    print(s.isPalindrome_3(0))
