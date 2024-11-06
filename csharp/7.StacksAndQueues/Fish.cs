using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Collections.Generic;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        var stack = new Stack<int>();
        int count = 0;
        for(int P = 0; P<A.Length; P++)
        {
            // current fish is moving downstream so add to stack
            if (B[P] == 1)
            {
                stack.Push(A[P]);
                continue;
            }
            while (stack.Count > 0)
            {
                count +=1;
                if (A[P] > stack.Peek())
                {
                    stack.Pop();
                }
                else
                {
                    break;
                }
            }
        }
        return A.Length - count;
    }
}

