using System;
using System.Collections.Generic;

class Program
{
static void Main(string[] args)
    {
        double [,] matrix1 = { { 1, 2 }, { 3, 4 } };
        double [,] matrix2 = { { -3, 9 }, { 1, 0 } };
        double [,] result = MatrixMath.Add(matrix1, matrix2);
        for (var i = 0; i < matrix1.GetLength(0); i++)
            {
                for (var j = 0; j < matrix2.GetLength(1); j++)
                    {
                        Console.WriteLine(result[i, j]);
                    }
            }
    }
}