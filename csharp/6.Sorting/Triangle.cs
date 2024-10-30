using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        for (int i=2; i<A.Length; i++)
        {
            long P = A[i-2];
            long Q = A[i-1];
            long R = A[i];
            if(P+Q>R && Q+R>P && R+P>Q)
            {
                return 1;
            }
        }
        return 0;
    }
}

