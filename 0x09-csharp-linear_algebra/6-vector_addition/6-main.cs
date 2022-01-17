using System;
using System.Collections.Generic;


class Program
{
static void Main(string[] args)
    {
        double [] vector1 = {9, 5};
        double [] vector2 = {1, 2};
        double [] res1;
        res1 = VectorMath.Add(vector1, vector2);
        Console.WriteLine(res1[0] + " " + res1[1]);
    }
}