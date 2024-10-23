using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        long count = (long) A.Length + 1;
        long expectedSum = ((count * (count + 1)) / 2);
        long actualSum = 0;
        for (int i = 0; i < A.Length; i++)
        {
			actualSum += A[i];
        }
        return (int) (expectedSum - actualSum);
    }
}
