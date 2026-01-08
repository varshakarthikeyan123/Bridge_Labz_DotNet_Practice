using System;

class TrigonometryCalculator
{
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = angle * Math.PI / 180;
        return new double[]
        {
            Math.Sin(radians),
            Math.Cos(radians),
            Math.Tan(radians)
        };
    }

    static void Main()
    {
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] result = CalculateTrigonometricFunctions(angle);
        Console.WriteLine($"Sine: {result[0]}, Cosine: {result[1]}, Tangent: {result[2]}");
    }
}
