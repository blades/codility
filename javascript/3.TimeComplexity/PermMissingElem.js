function solution(A) {
  const count = A.length + 1;
  const expectedSum = (count * (count + 1)) / 2;
  let actualSum = 0;

  for (const num of A) {
    actualSum += num;
  }

  return expectedSum - actualSum;
}
