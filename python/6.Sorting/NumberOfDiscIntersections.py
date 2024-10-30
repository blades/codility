# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")
from bisect import bisect_right


def solution(A):
    count = 0

    circles = sorted([(i-A[i], i+A[i]) for i in range(len(A))])
    lefts = [i[0] for i in circles]

    for i in range(len(lefts)):
        right = circles[i][1]
        result = bisect_right(lefts, right)
        count -= (i+1)
        count += result
        if count > 1e07:
            return -1
    return count
