using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Collections.Generic;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] H) {
        Stack<int> stack = new Stack<int>();
        int count = 1;
        stack.Push(H[0]);
        for (int i = 1; i < H.Length; i++)
        {
            int block = H[i];

            while (stack.Count > 0 && stack.Peek() > block)
            {
                stack.Pop();
            }

            if (stack.Count == 0 || block > stack.Peek())
            {
                stack.Push(block);
                count++;
            }

        }
        return count;
    }
}

