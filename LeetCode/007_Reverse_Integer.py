# encoding: utf-8

# 007_Reverse_Integer
# 2021/01/07
#
# Assume we are dealing with an environment that could only store integers
# within the 32-bit signed integer range: [−2^31,  2^31 − 1]. For the purpose of this problem,
# assume that your function returns 0 when the reversed integer overflows.
#
# Example 1:
# Input: x = 123
# Output: 321
#
# Example 2:
# Input: x = -123
# Output: -321
#
# Example 3:
# Input: x = 120
# Output: 21
#
# Example 4:
# Input: x = 0
# Output: 0

class Solution:
    def reverse(self, x):
        x_list = list(str(x))
        reverse_x = 0

        # postive => False, negative => True
        x_sign = False
        if x_list[0] == "-":
            x_sign = True
            x_list.pop(0)

        for y in range(len(x_list) - 1, -1, -1):
            reverse_x += int(x_list[y]) * pow(10, y)

        reverse_x = reverse_x * -1 if x_sign else reverse_x
        if reverse_x >= pow(-2, 31) and reverse_x <= pow(2, 31) - 1:
            return reverse_x
        else:
            return 0

    def reverse_2(self, x):
        reverse_x = 0

        # postive => False, negative => True
        x_sign = False
        if x < 0:
            x_sign = True
            x = abs(x)

        x_length = len(str(x))
        for i in range(x_length):
            y = x % 10
            reverse_x += y * pow(10, x_length - 1 - i)
            x = x // 10

        reverse_x = reverse_x * -1 if x_sign else reverse_x
        # pow(-2, 31) = -2 ** 31
        if reverse_x >= pow(-2, 31) and reverse_x <= pow(2, 31) - 1:
            return reverse_x
        else:
            return 0

    '''
    123 % 10 = 3
    123 // 10 = 12

    12 % 10 = 2
    12 // 10 = 1

    1 % 10 = 1
    1 // 10 = 0

    0 + 3 = 3
    3 * 10 = 30
    => (0 + 3) * 10 =30
    30 + 2 = 32
    32 * 10 = 320
    => (30 + 2) * 10 =320
    320 + 1 = 321 (if 1 // 10 = 0 then stop)
    '''
    def reverse_3(self, x):
        reverse_x = 0
        # postive => False, negative => True
        x_sign = False
        if x < 0:
            x_sign = True
            x = abs(x)

        while x != 0:
            mod_x = x % 10
            x = x // 10
            if x != 0:
                reverse_x = (reverse_x + mod_x) * 10
            else:
                reverse_x = (reverse_x + mod_x)

        reverse_x = reverse_x * -1 if x_sign else reverse_x
        # pow(-2, 31) = -2 ** 31
        if reverse_x >= pow(-2, 31) and reverse_x <= pow(2, 31) - 1:
            return reverse_x
        else:
            return 0

    # use String Slices s[start:end:stride]
    def reverse_4(self, x):
        res = int(str(abs(x))[::-1])
        if x < 0:
            res = -res
        if res <= pow(-2, 31) and res >= pow(2, 31) - 1:
            res = 0
        return res

if __name__ == '__main__':
    # begin
    s = Solution()
    print("-----reverse-----")
    print(s.reverse(123))
    print(s.reverse(-123))
    print(s.reverse(120))
    print(s.reverse(0))
    print(s.reverse(1534236469))
    print("-----reverse_2-----")
    print(s.reverse_2(123))
    print(s.reverse_2(-123))
    print(s.reverse_2(120))
    print(s.reverse_2(0))
    print(s.reverse_2(1534236469))
    print("-----reverse_3-----")
    print(s.reverse_3(123))
    print(s.reverse_3(-123))
    print(s.reverse_3(120))
    print(s.reverse_3(0))
    print(s.reverse_3(1534236469))
