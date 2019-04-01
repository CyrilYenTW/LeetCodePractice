
class Solution:
    def repeatedNTimes(self, A: 'List[int]') -> 'int':
    	dic = []

    	for num in A:
    		if num in dic:
    			return num
    		else:
    			dic.append(num)

    	return 0

nums = [5,1,5,2,5,3,5,4]

print(Solution().repeatedNTimes(nums))
