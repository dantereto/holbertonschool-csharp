using System;
/// <summary> Class of matrix</summary>
class MatrixMath
{
    /// <summary>double for determinat</summary>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2)
        {
            return Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[1, 0], 2);
        }

        if (matrix.GetLength(0) == matrix.GetLength(1) ||
            matrix.GetLength(0) < 2 || matrix.GetLength(0) < 3)
        {
            double sum = 0;
            sum += matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[2, 1] * matrix[1, 2]);
            sum -= matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[2, 0] * matrix[1, 2]);
            sum += matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[2, 0] * matrix[1, 1]);
            return Math.Round(sum, 2);
        }
        return -1;
    }
}
