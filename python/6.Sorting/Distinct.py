def solution(A):
    visited = set()
    sum = 0
    for value in A:
        if value not in visited:
            visited.add(value)
            sum += 1
    return sum
