def solution(A, K):
    count = len(A)
    if (count == 0):
        return A
    K = K % count
    A[:] = A[count-K:] + A[:count-K]
    return A
