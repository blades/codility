def solution(A):
    multiplier = 0
    total = 0
    for value in A:
        if value == 0:
            multiplier += 1
        else:
            total += multiplier
            if total > 1000000000:
                return -1
    return total
