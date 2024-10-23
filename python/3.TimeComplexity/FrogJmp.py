import math

def solution(X, Y, D):
    distance = Y - X
    hops = distance / D
    count = math.ceil(hops)
    return count
