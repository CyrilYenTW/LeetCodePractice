
class Solution:
    def arrayPairSum(self, nums):
    	result = 0
    	length = len(nums)
    	lastIndex = length - 1
    	for i in range(0, (int)(length/2)):    		
    		result += min(nums[i], nums[lastIndex - i])

    	return result
        


print (Solution().arrayPairSum([1, 4, 3, 2]))

