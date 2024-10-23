def solution(X, A):
    found = [-1] * X
    for i in range(len(A)):
        currentVal = A[i]
        if found[currentVal - 1] == -1:
            found[currentVal - 1] = i
    if -1 in found:
        return -1
    return max(found)
