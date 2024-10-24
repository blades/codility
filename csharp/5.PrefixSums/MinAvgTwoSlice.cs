using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        float minAvg = float.MaxValue;
        int minIndex = Int32.MaxValue;

        for (int i = 1; i< A.Length; i++)
        {
            float pairAvg = (float) (A[i-1] + A[i]) / (float) 2;
            if (pairAvg < minAvg)
            {
                minAvg = pairAvg;
                minIndex = i - 1;
            }
            if(i > 1)
            {
                float tripletAvg = (float) (A[i-2] + A[i-1] + A[i]) / (float) 3;
                if (tripletAvg < minAvg)
                {
                    minAvg = tripletAvg;
                    minIndex = i - 2;
                }
            }
        }
        return minIndex;
    }
}

