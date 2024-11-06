# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")

def solution(A):
    if len(A) == 0:
        return -1
    counts = {}
    maxCount = 0
    maxIndex = 0
    for i in range (0, len(A)):
        a = A[i]
        if a in counts:
            counts[a] += 1
        else:
            counts[a] = 1
        if counts[a] > maxCount:
            maxCount = counts[a]
            maxIndex = i
    if maxCount > len(A) // 2:
        return maxIndex
    return -1

