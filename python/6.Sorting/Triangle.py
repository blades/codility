# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")

def solution(A):
    # Implement your solution here
        A.sort()
        for i in range(2, len(A)):
            P = A[i-2]
            Q = A[i-1]
            R = A[i]
            if P+Q>R and Q+R>P and R+P>Q:
                return 1
        return 0

