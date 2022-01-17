using System;
/// <summary> Class of vectors</summary>
class VectorMath
{
    /// <summary> double to sum vectors</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 || vector1.Length == 3 || vector1.Length == vector2.Length)
        {
            for (var i = 0; i < vector1.Length; i++)
                vector1[i] += vector2[i];
            return vector1;
        }
        return new double[1]{-1};
    }   
}
