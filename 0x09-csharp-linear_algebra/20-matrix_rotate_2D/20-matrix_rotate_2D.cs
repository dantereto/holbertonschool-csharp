using System;

/// <summary> Class of matrix</summary>
class MatrixMath
{
     /// <summary>double for rotate</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] newMatrix = new double[2, 2];            
            double[,] rotationMatrix = {
                {Math.Cos(angle), Math.Sin(angle)},
                {-1 * Math.Sin(angle), Math.Cos(angle)}
            };

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    for (int k = 0; k < rotationMatrix.GetLength(1); k++)
                    {
                        newMatrix[j, k] = Math.Round(newMatrix[j, k] + (matrix[j, i] * rotationMatrix[i, k]), 2);
                    }
                }
            }
            return newMatrix;
        }
        return new double[,] {{-1}};
    }
}