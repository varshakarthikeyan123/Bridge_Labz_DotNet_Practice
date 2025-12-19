using System;

class TriangleArea
{
    public static void Execute()
    {
        Console.Write("Enter base: ");
        double baseValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height: ");
        double heightValue = Convert.ToDouble(Console.ReadLine());

        double area = 0.5 * baseValue * heightValue;

        Console.WriteLine($"Area of triangle is {area}");
    }
}
