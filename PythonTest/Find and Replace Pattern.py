class Solution:
	def findAndReplacePattern(self, words: 'List[str]', pattern: 'str') -> 'List[str]':
		key = self.getModule(pattern)
		result = []

		for word in words:
			if key == self.getModule(word):
				result.append(word)

		return result

	def getModule(self, word: 'str'):
		
		patterms = []
		result = ''

		for c in word:
			if (c in patterms) == False:
				patterms.append(c)

			result = result + str(patterms.index(c))

		return result


a = Solution().findAndReplacePattern(['aabb', 'ccbb', 'asdsa'], 'hhdd')

print(a)

