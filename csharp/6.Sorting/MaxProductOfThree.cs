using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A)
    {
        Array.Sort(A);
        int n = A.Length;
        // Check largest 3
        int maxLargest = A[n - 1] * A[n - 2] * A[n - 3];
        // Check largest multiplied by two smallest in case
        // Two smallest are both negative numbers
        int maxNegative = A[0] * A[1] * A[n - 1];
        return Math.Max(maxLargest, maxNegative);
    }
}

