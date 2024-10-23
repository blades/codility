def solution(A):
    count = len(A) + 1
    expected = (count * (count + 1)) // 2
    actual = sum(A)
    return expected - actual
