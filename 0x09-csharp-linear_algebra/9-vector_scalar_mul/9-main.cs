using System;
using System.Collections.Generic;

class Program
{
static void Main(string[] args)
    {
        double [] vector1 = {9, 5};
        double [] res1;
        res1 = VectorMath.Multiply(vector1, 2);
        Console.WriteLine(res1[0] + " " + res1[1]);
    }
}