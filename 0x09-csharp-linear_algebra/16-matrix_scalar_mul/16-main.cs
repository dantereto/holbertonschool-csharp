using System;
using System.Collections.Generic;

class Program
{
static void Main(string[] args)
    {
        double [,] matrix1 = { { 1, 2 }, { 3, 4 } };
        double [,] result;
        for (var i = 0; i < matrix1.GetLength(0); i++)
            {
                for (var j = 0; j < matrix1.GetLength(1); j++)
                    {
                        result = MatrixMath.MultiplyScalar(matrix1, 2);
                        Console.WriteLine(result[0, 0]);
                    }
            }
    }
}