using System;
/// <summary> Class of vectors</summary>
class VectorMath
{
    /// <summary>double for vector</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2 || vector.Length == 3)
        {
            double sum = 0;
            foreach(var value in vector)
                sum += Math.Pow(value, 2);
            return Math.Round(Math.Sqrt(sum), 2);
        }
        return -1;
    }
}
