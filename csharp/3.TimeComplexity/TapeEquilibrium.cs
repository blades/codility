using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Linq;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int length = A.Length;
        int rightSide = A.Sum();
        int minDiff = int.MaxValue;
        int leftSide = 0;
        for (int i = 0; i < length - 1; i++)
        {
            leftSide += A[i];
            rightSide -= A[i];
            int diff = Math.Abs(leftSide - rightSide);
            minDiff = Math.Min(minDiff, diff);
        }
        return minDiff;
    }
}
