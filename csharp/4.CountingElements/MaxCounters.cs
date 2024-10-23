using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        int[] counters = new int[N];
        int maxCounter = 0;
        int minValue = 0;
        foreach (int current in A)
        {
            if (current <= N)
            {
                if(counters[current -1] < minValue)
                {
                    counters[current -1] = minValue;
                }
                counters[current -1]++;
                if (maxCounter < counters[current -1])
                {
                    maxCounter = counters[current -1];
                }
            }
            else
            {
                minValue = maxCounter;
            }
        }
        for(int i = 0; i < N; i++)
        {
            if( counters[i] < minValue)
            {
                counters[i] = minValue;
            }
        }
        return counters;
    }
}

