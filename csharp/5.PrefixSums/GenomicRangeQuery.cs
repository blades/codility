using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(string S, int[] P, int[] Q)
    {
        int[] countA = new int[S.Length + 1];
        int[] countC = new int[S.Length + 1];
        int[] countG = new int[S.Length + 1];
        int[] countT = new int[S.Length + 1];

        int counter = 1;
        foreach (char c in S)
        {
            if (c == 'A')
            {
                countA[counter]++;
            }
            if (c == 'C')
            {
                countC[counter]++;
            }
            if (c == 'G')
            {
                countG[counter]++;
            }
            if (c == 'T')
            {
                countT[counter]++;
            }
            if (counter > 0)
            {
                countA[counter] += countA[counter - 1];
                countC[counter] += countC[counter - 1];
                countG[counter] += countG[counter - 1];
                countT[counter] += countT[counter - 1];
            }
            counter++;
        }
        int[] output = new int[P.Length];
        for (int i = 0; i < P.Length; i++)
        {
            int start = P[i];
            int end = Q[i] + 1;
            int aDiff = countA[end] - countA[start];
            int cDiff = countC[end] - countC[start];
            int gDiff = countG[end] - countG[start];
            int tDiff = countT[end] - countT[start];
            if (aDiff > 0)
            {
                output[i] = 1;
            }
            else if (cDiff > 0)
            {
                output[i] = 2;
            }
            else if (gDiff > 0)
            {
                output[i] = 3;
            }
            else if (tDiff > 0)
            {
                output[i] = 4;
            }
        }
        return output;
    }
}

