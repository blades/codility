def solution(A):
    seen = set()
    max_val = -1
    for num in A:
        if num in seen:
            return 0
        seen.add(num)
        if num > max_val:
            max_val = num
    if max_val != len(A):
        return 0
    return 1
