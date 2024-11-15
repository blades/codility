function solution(X, Y, D) {
    const distance = Y - X;
    const hops = Math.ceil(distance / D);
    const count = Math.floor(hops);
    return count;
}
