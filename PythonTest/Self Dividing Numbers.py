class Solution:
    def selfDividingNumbers(self, left, right):
    	result  = []

    	for i in range(left, right + 1):
    		s = str(i)
    		flag = True
    		for index in range(1, len(s) + 1):
    			if ( s[index - 1] == '0' or i % (int)(s[index - 1]) != 0):
    				flag = False
    				break

    		if flag :
    			result.append(i)

    	return result

        



print(Solution().selfDividingNumbers(1, 22))
