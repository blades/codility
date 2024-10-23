using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int Y, int D) {
        int distance = Y - X;
        double hops = (double)distance / D;
        int count = (int)Math.Ceiling(hops);
        return count;
    }
}
