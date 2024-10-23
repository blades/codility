using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public class Solution
{
    public int[] solution(int[] A, int K)
    {
        int count = A.Length;
        if (count == 0)
        {
            return A;
        }
        K = K % count;
        Array.Reverse(A, 0, count - K);
        Array.Reverse(A, count - K, K);
        Array.Reverse(A, 0, count);
        return A;
    }
}
