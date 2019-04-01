class Solution:
    def deckRevealedIncreasing(self, deck: 'List[int]') -> 'List[int]':
    	deck = sorted(deck, reverse=True)

    	result = []

    	for num in deck:
    		if result:
    			last = result.pop()
    			result = [num] + [last] + result
    		else:
    			result.append(num)




    	print(result)


nums = [17,13,11,2,3,5,7]

Solution().deckRevealedIncreasing(nums)