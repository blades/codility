using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Collections.Generic;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < A.Length; i++)
        {
            set.Add(A[i]);
        }
        int smallestMissing = 1;
        while (set.Contains(smallestMissing))
        {
            smallestMissing++;
        }
        return smallestMissing;
    }
}
