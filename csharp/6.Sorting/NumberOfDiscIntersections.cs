using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");


class Solution 
{
    const int MAX_COUNT = 10000000;

    public int solution(int[] A) 
    {
        Circle[] circles = new Circle[A.Length];
        for (int i = 0; i < A.Length ; i ++)
        {
            Circle circle = new Circle(i, A[i]);
            circles[i]= circle;
        }
        Array.Sort(circles);
        int count = 0;

        for (int i = 0; i< circles.Length; i++)
        {
            Circle current = circles[i];
            for (int j = i + 1; j < circles.Length; j++)
            {
                Circle compareCircle = circles[j];
                if (compareCircle.Left <= current.Right)
                {
                    count += 1;
                }
                else
                {
                    break;
                }
            }
            if(count > MAX_COUNT) return -1;
        }
        return count;
    }
}

public class Circle : IComparable<Circle>
{
    public long Left { get; set; }
    public long Right { get; set; }
    public long Centre { get; set; }
    public long Radius { get; set; }

    public Circle(long centre, long radius)
    {
        this.Centre = centre;
        this.Left = centre - radius;
        this.Right = centre + radius;
        this.Radius = radius;
    }

    public int CompareTo(Circle other)
    {
        if (other == null)
        {
            return 1;
        }
        return this.Left.CompareTo(other.Left) == 0 ? this.Centre.CompareTo(other.Centre) : this.Left.CompareTo(other.Left);
    }
}

