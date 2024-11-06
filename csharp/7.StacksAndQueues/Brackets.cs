using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Collections.Generic;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        var stack = new Stack<char>();
        foreach (char c in S)
        {
            if (c.Equals('(') || c.Equals('{') || c.Equals('['))
            {
                stack.Push(c);
            }
            else if (stack.Count ==0)
            {
                return 0;
            }
            else if (c.Equals(')') && !(stack.Peek().Equals('(')))
            {
                return 0;
            }
            else if (c.Equals('}') && !(stack.Peek().Equals('{')))
            {
                return 0;
            }
            else if (c.Equals(']') && !(stack.Peek().Equals('[')))
            {
                return 0;
            }
            else
            {
                stack.Pop();
            }
        }
        if (stack.Count == 0) return 1;
        return 0;
    }
}

