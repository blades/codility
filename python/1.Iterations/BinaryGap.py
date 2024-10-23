def solution(N):
    currentGap = 0
    longestGap = 0
    previousBit = False
    isStart = True
    while N > 0:
        currentBit = (N % 2 == 1)
        # start gap - current = 0, previous = 1
        if not currentBit and previousBit and not isStart:
            currentGap = 1
        # continuing gap - 0 and 0
        elif not currentBit and not previousBit and not isStart:
            currentGap += 1
        # end gap - previous = 0, current = 1
        elif currentBit and not previousBit:
            if currentGap > longestGap:
                longestGap = currentGap
            # reset count
            currentGap = 0
            isStart = False
        # set previous bit to current bit
        previousBit = currentBit
        N = N//2
    return longestGap
