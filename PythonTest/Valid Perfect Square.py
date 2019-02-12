import math

class Solution:
    def isPerfectSquare(self, num):
        return math.sqrt(num).is_integer()

print(Solution().isPerfectSquare(1000))