using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Collections.Generic;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // check for uniqueness
        HashSet<int> inList = new HashSet<int>();
        long total = 0;
        int maxVal = -1;
        for (int i = 0; i < A.Length; i++)
        {
            if(inList.Contains(A[i]))
            {
                return 0;
            }
            inList.Add(A[i]);
            // sum array
            total += A[i];
            // find max value in array
            if (A[i] > maxVal)
            {
                maxVal = A[i];
            }
        }
        // if max val != array length, return 0
        if (maxVal != A.Length)
        {
            return 0;
        }
        return 1;
    }
}


[9, 5, 7, 3, 2, 7, 3, 1, 10, 8]
[1,2,3,5]
[1,2,2,2]
