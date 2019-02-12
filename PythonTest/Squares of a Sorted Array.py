

def sortedSquares(A):
	result = []

	for i in range(len(A)):
		result.append(A[i] * A[i])

	result.sort()

	return result


input_array = [-7, -3, 2, 15]

sortedSquares(input_array)
    	