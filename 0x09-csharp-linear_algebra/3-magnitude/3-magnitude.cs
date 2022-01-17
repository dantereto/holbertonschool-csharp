using System;
class VectorMath
{
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
    static void Main(string[] args)
    {
        double [] vector = {9, 5};
        Console.WriteLine(VectorMath.Magnitude(vector));
    }
}
