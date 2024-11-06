# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")
from collections import deque

def solution(H):
    stack = deque()
    count = 1
    stack.append(H[0])
    for i in range (1, len(H)):
        while len(stack) > 0 and stack[-1] > H[i]:
            stack.pop()
        if len(stack) == 0 or H[i] > stack[-1]:
            stack.append(H[i])
            count += 1
    return count
