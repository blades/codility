def solution(A):
    length = len(A)
    right_side = sum(A)
    min_diff = float('inf')
    left_side = 0
    for i in range(0, length - 1):
        left_side += A[i]
        right_side -= A[i]
        diff = abs(left_side - right_side)
        min_diff = min(min_diff, diff)
    return min_diff
