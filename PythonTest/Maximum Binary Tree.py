from BasicNode import PrintTree

class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution:
    def constructMaximumBinaryTree(self, nums: 'List[int]') -> 'TreeNode':
        result = TreeNode(nums[0])
        for num in nums[1:]:
            result = self.process(result, num)
        return result

    def process(self, node: TreeNode, num: int) -> TreeNode:
        if node is None:
            return TreeNode(num)

        if node.val > num:
            node.right = self.process(node.right, num)
            return node

        if  node.val < num:
            newNode = TreeNode(num)
            newNode.left = node
            return newNode

        return TreeNode()

class Solution2:
    def constructMaximumBinaryTree2(self, nums: 'List[int]') -> TreeNode:
        stack = []
        for num in nums:
            node = TreeNode(num)

            while stack and stack[-1].val < num:
                lastNode = stack.pop()
                node.left = lastNode
            if stack:
                stack[-1].right = node

            stack.append(node)

        return stack[0]





nums = [3,2,1,6,0,5]

result = Solution2().constructMaximumBinaryTree2(nums)

PrintTree(result)