# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")
from collections import deque

def solution(S):
    stack = deque()
    for c in S:
        if c =='(':
            stack.append(c)
        elif len(stack) == 0:
            return 0
        elif c == ')' and not stack[-1] == '(':
            return 0
        else:
            stack.pop()
    if len(stack) == 0:
        return 1
    return 0
