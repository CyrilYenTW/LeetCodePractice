import BasicNode

class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def searchBST(self, root: 'TreeNode', val: 'int') -> 'TreeNode':
    	if root.val == val:
    		return root

    	if root.left:
    		temp = self.searchBST(root.left, val)
    		if temp:
    			return temp

    	if root.right:
    		temp = self.searchBST(root.right, val)
    		if temp:
    			return temp

    	return None

values = TreeNode(4)
values.left = TreeNode(2)
values.left.left = TreeNode(1)
values.left.right = TreeNode(3)
values.right = TreeNode(7)


result = Solution().searchBST(values, 4)

BasicNode.PrintTree(result)
