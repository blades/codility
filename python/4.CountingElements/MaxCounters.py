# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")

def solution(N, A):
    counters = [0] * N
    max_counter = 0
    min_value = 0

    for current in A:
        if current <= N:
            if counters[current - 1] < min_value:
                counters[current - 1] = min_value
            counters[current - 1] += 1
            if max_counter < counters[current - 1]:
                max_counter = counters[current - 1]
        else:
            min_value = max_counter

    for i in range(N):
        if counters[i] < min_value:
            counters[i] = min_value

    return counters
