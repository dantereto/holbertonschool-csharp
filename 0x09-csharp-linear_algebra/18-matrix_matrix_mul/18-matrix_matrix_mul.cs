using System;
/// <summary> Class of matrix</summary>
class MatrixMath
{
    /// <summary>double for matrix scalar</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double [,] result; 
        if (matrix1.Length != 0 ||
            matrix2.Length != 0 ||
            matrix1.GetLength(1) == matrix2.GetLength(0))
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
