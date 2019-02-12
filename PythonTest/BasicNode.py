class TreeNode:
	def __init__(self, x):
	    self.val = x
	    self.left = None
	    self.right = None

def SortTree(tree: 'TreeNode', key: 'string', dic: 'dict'):
	if tree == None:
		return []

	dic[key] = tree.val

	if tree.left:
		SortTree(tree.left, key+'L', dic)

	if tree.right:
		SortTree(tree.right, key+'R', dic)

	return dic

def PrintTree(tree: 'TreeNode'):
	result = SortTree(tree, '', {})

	if result == []:
		print(result)
		return

	result = sorted(result.items(), key=lambda m: len(m[0]))

	arr = []

	for temp in result:
		arr.append(temp[1])

	print(arr)