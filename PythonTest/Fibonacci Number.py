class Solution:
    def fib(self, N):
    	result = 1
    	pre = 0
    	for i in range(1, N):
    		new = result + pre
    		pre = result
    		result = new
    		
    	return 0 if N == 0 else result

        

print(Solution().fib(6))