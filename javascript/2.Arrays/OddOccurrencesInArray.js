function solution(A) {
  let total = 0;

  for (const value of A) {
    total ^= value;
  }

  return total;
}
