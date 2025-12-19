using System;

class Q8_PowerCalculator
{
    public static void Calculate()
    {
        Console.Write("Enter base: ");
        double baseNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter exponent: ");
        double exponent = double.Parse(Console.ReadLine());

        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine("Result = " + result);
    }
}
