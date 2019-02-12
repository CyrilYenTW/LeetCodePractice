
class Solution:
    def kClosest(self, points, K):
    	return sorted(points, key = lambda m:(m[0]**2 + m[1]**2))[:2]


print(Solution().kClosest([[1,3],[-2,2], [1, 1], [8, 6]], 2))

