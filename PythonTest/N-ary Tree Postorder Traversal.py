
class Node:
    def __init__(self, val, children):
        self.val = val
        self.children = children

class Solution:
    def temp(self, root: 'Node', result: 'List[int]'):
        for value in root.children:
            self.temp(value, result)

        result.append(root.val)

        return result

    def postorder(self, root: 'Node') -> 'List[int]':
        return self.temp(root, []) if root else []