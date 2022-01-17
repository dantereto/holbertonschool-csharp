using System;
/// <summary> Class of vectors</summary>
class VectorMath
{
    /// <summary>double for scalar</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        
        if (vector.Length == 2 || vector.Length == 3)
        {
            for (var i = 0; i < vector.Length; i++)
                vector[i] *= scalar;
            return vector;
        }
        return new double[1]{-1};
    }
}
