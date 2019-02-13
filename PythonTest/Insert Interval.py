
def PrintIntervals(values: 'List[Interval]'):
	for value in values:
		print(f'({value.start}, {value.end})')

class Interval:
	def __init__(self, s=0, e=0):
		self.start = s
		self.end = e

class Solution:
    def insert(self, intervals: 'List[Interval]', newInterval: 'Interval') -> 'List[Interval]':
    	if intervals == None:
    		return newInterval

    	isDone = False
    	temp = Interval(0, 0)
    	result = []

    	for idx, value in enumerate(intervals):

    		if isDone == False and value.start <= newInterval.start and idx <= len(intervals)-2 and intervals[idx+1].start > newInterval.end:
    			isDone = True
    			result.append(Interval(value.start, newInterval.end))
    			continue

    		if isDone == False and value.start < newInterval.start and value.end > newInterval.start:
    			temp.start = value.start
    			continue

    		if isDone == False and value.start <= newInterval.end and value.end > newInterval.end:
    			temp.end = value.end
    			isDone = True
    			result.append(temp)
    			continue

    		if isDone == False and temp.start:
    			continue

    		result.append(value)

    	PrintIntervals(result)

    	return result

test = [Interval(1, 2), Interval(3, 5), Interval(6, 7), Interval(8, 10), Interval(12, 16)]

Solution().insert(test, Interval(4, 8))
