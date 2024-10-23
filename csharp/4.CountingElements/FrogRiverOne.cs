using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Linq;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        int[] found = new int[X];
        Array.Fill(found, -1);
        for (int i = 0; i < A.Length; i++)
        {
            int currentVal = A[i];
            if (found[currentVal - 1] == -1)
            {
                found[currentVal - 1] = i;
            }
        }
        if (found.Any(x => x == -1))
        {
            return -1;
        }
        return found.Max();
    }
}
