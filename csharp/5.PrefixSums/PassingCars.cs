using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int multiplier = 0;
        int total = 0;
        foreach (int value in A)
        {
            if(value == 0)
            {
                multiplier+=1;
            }
            else
            {
                total += multiplier;
                if (total > 1000000000)
                {
                    return -1;
                }
            }
        }
        return total;
    }
}

