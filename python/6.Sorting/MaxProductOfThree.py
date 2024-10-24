def solution(A):
    A.sort()
    n = len(A)
    # check largest 3
    max_largest = A[n-1] * A[n-2] * A[n-3]
    # check largest multiplied by two smallest in case
    # two smallest are both negative numbers
    max_negative = A[0] * A[1] * A[n-1]
    return max(max_largest, max_negative)
