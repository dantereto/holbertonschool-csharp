using System;
/// <summary> Class of matrix</summary>
class MatrixMath
{
    /// <summary>double for matrix scalar</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) == 2 || matrix.GetLength(1) == 2)
        {
            double [,] shear = new double[,] {{1, 0}, {0, 1}};
            if (direction == 'x')
                shear[1, 0] = factor;
            else if (direction == 'y')
                shear[0, 1] = factor;
            else
                return new double[,] {{-1}};
            double [,] result = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < 2; k++)
                        sum += matrix[i, k] * shear[k, j];
                    result[i, j] = Math.Round(sum, 2);
                }
            }
            return result;
        }
        return new double[,] {{-1}};
    }
}
