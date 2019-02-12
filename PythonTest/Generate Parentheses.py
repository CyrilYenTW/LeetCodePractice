

class Solution:
	def generateParenthesis(self, n):
		result = []
		self.test(n, n, '', result)

		return result

	def test(self, l, r, s, result):
		if l + r == 0:
			result.append(s)
			return

		if r - 1 > l:
			return self.test(l - 1, r, s + '(', result)

		self.test(l, r - 1, s + ')', result)
		self.test(l - 1, r, s + '(', result)









print(Solution().generateParenthesis(2))