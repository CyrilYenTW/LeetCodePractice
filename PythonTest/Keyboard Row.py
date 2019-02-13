
class Solution:

    def IsSameRowWord(self, word:'str') -> 'bool':
        datas = [
            ['q','w','e','r','t','y','u','i','o','p'],
            ['a','s','d','f','g','h','j','k','l',],
            ['z','x','c','v','b','n','m',]
        ]

        word = str.lower(word)

        for data in datas:
            if (word[0] in data) == False:
                continue

            for c in word:
                if (c in data) == False:
                    return False

        return True

    def findWords(self, words: 'List[str]') -> 'List[str]':
        result = []

        for word in words:
            if self.IsSameRowWord(word):
                result.append(word)

        return result


print(Solution().findWords(["Hello", "Alaska", "Dad", "Peace"]))
