function solution(N) {
  let currentGap = 0;
  let longestGap = 0;
  let previousBit = false;
  let isStart = true;

  while (N > 0) {
    const currentBit = (N % 2 === 1);

    if (!currentBit && previousBit && !isStart) {
      currentGap = 1;
    } else if (!currentBit && !previousBit && !isStart) {
      currentGap++;
    } else if (currentBit && !previousBit) {
      if (currentGap > longestGap) longestGap = currentGap;
      currentGap = 0;
      isStart = false;
    }

    previousBit = currentBit;
    N = Math.floor(N / 2);
  }

  return longestGap;
}
