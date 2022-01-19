using System;
/// <summary> Class of matrix</summary>
class MatrixMath
{
    /// <summary>double for matrix transpose</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] result = new double [matrix.GetLength(1), matrix.GetLength(0)];
        if (matrix != null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    result[i, j] = matrix[j, i];
            }
            return result;
        }
        return new double[,]{};
    }
}
