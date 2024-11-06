from collections import deque

def solution(A, B):
    stack = deque()
    count = 0
    for P in range(len(A)):
        if B[P] == 1:
            stack.append(A[P])
            continue
        while stack:
            count += 1
            if A[P] > stack[-1]:
                stack.pop()
            else:
                break
    return len(A) - count
