using System;
/// <summary> Class of matrix</summary>
class MatrixMath
{
     /// <summary>double for matrix multiply</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double [,] result; 
        if (((matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2) ||
            (matrix1.GetLength(0) == 3  &&matrix2.GetLength(1) == 3) &&
            matrix1.Length == matrix2.Length))
        {
            result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                        result[i, j] += matrix1[i, k] * matrix2[k, j];

                }
            }
            return result;
        }
        return new double[,] {{-1}};
    }
}
