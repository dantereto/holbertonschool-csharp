using System;
/// <summary> Class of matrix</summary>
class VectorMath
{
    /// <summary>double for matrix transpose</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 3 || vector2.Length == 3)
        {
            double x = vector1[1] * vector2[2] - vector1[2] * vector2[1];
            double y = vector1[2] * vector2[0] - vector1[0] * vector2[2];
            double z = vector1[0] * vector2[1] - vector1[1] * vector2[0];
            var res = new double[]{x, y, z};
            return res;
        }
        return new double[1] { -1 };
    }
}
