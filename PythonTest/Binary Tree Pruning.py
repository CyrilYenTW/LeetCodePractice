from BasicNode import TreeNode
from BasicNode import PrintTree2

class Solution:
    def pruneTree(self, root: 'TreeNode') -> 'TreeNode':
        self.temp(root, False)
        return root


    def temp(self, root: "TreeNode", flag: "bool"):
        if root.left == None and root.right == None:
            return True if root.val == 1 else False

        if root.left:
            leftFlag = self.temp(root.left, False)
            root.left = root.left if leftFlag else None
            flag = flag | leftFlag

        if root.right:
            rightFlag = self.temp(root.right, False)
            root.right = root.right if rightFlag else None
            flag = flag | rightFlag

        return flag | (root.val == 1)

datas = TreeNode(1)

datas.left = TreeNode(1)
datas.left.left = TreeNode(0)
datas.left.right = TreeNode(0)

datas.right = TreeNode(0)
datas.right.left = TreeNode(0)

a = Solution().pruneTree(datas)

PrintTree2(a)

