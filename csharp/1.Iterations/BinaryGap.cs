using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        int currentGap = 0;
        int longestGap = 0;

        bool previousBit = false;
        bool isStart = true;
        while (N > 0)
        {
            bool currentBit = (N % 2 == 1);
            // start gap - current = 0, previous = 1
            if(!currentBit && previousBit && !isStart)
            {
                currentGap = 1;
            } 
            // continuing gap - 0 and 0
            else if (!currentBit && !previousBit && !isStart)
            {
                currentGap++;
            }
            // end gap - previous = 0, current = 1
            else if (currentBit && !previousBit)
            {
                if (currentGap > longestGap) longestGap = currentGap;
                // reset count
                currentGap = 0;
                isStart = false;
            }
            // set previous bit to current bit
            previousBit = currentBit;
            N = N/2;
        }       
        return longestGap;
    }
}
