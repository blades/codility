function solution(A) {
  const length = A.length;
  let rightSide = A.reduce((sum, num) => sum + num, 0);
  let minDiff = Infinity;
  let leftSide = 0;

  for (let i = 0; i < length - 1; i++) {
    leftSide += A[i];
    rightSide -= A[i];
    const diff = Math.abs(leftSide - rightSide);
    minDiff = Math.min(minDiff, diff);
  }

  return minDiff;
}
