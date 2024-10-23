def solution(A, B, K):
        firstNum = A // K
        secondNum = B // K
        diff = secondNum - firstNum
        if A % K == 0:
            diff += 1;
        return diff;
