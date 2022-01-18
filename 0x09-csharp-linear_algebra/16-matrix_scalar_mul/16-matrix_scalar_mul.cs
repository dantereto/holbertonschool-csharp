using System;
/// <summary> Class of matrix</summary>
class MatrixMath
{
    /// <summary>double for matrix scalar</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if ((matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) ||
            (matrix.GetLength(0) == 3  &&matrix.GetLength(1) == 3))
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] *= scalar;
            }
            return matrix;
        }
        return new double[,] {{-1}};
    }
}
