function solution(A, K) {
  const count = A.length;

  if (count === 0) {
    return A;
  }
  K %= count;
  A.splice(0, count, ...A.slice(count - K, count), ...A.slice(0, count - K));
  return A;
}
