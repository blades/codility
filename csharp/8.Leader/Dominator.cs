using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Collections.Generic;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        if (A.Length == 0) return -1;
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int maxCount = 0;
        int maxIndex = 0;
        for (int i = 0; i< A.Length; i++)
        {
            int a = A[i];
            if (counts.ContainsKey(a))
                counts[a] = counts[a]+1;
            else
                counts[a] = 1;
            if (counts[a] > maxCount)
            {
                maxCount = counts[a];
                maxIndex = i;
            }
        }
        if (maxCount > (A.Length / 2)) return maxIndex;
        return -1;
    }
}
