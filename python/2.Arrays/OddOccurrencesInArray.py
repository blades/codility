def solution(A):
    total = 0
    for value in A:
        total ^= value
    return total
