using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Collections.Generic;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        HashSet<int> visited = new HashSet<int>();
        int sum = 0;
        foreach (int value in A)
        {
            if(!visited.Contains(value))
            {
                visited.Add(value);
                sum += 1;
            }
        }
        return sum;
    }
}
