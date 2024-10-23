using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int A, int B, int K) {
        int firstNum = A / K;
        int secondNum = B / K;
        int diff = secondNum - firstNum;
        if ( A % K == 0)
        {
            diff += 1;
        }
        return diff;
    }
}
