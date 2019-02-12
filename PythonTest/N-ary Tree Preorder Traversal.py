class Node:
    def __init__(self, val, children):
        self.val = val
        self.children = children

class Solution:
    def temp(self, root: 'Node', result: 'List[int]') -> 'List[int]':
        result.append(root.val)

        for child in root.children:
            self.temp(child, result)

        return result

    def preorder(self, root: 'Node') -> 'List[int]':
        return self.temp(root, []) if root else []