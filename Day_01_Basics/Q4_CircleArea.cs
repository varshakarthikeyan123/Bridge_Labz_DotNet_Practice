using System;
class Q4_CircleArea
{
    public static void CalculateArea()
    {
        Console.Write("Enter radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        Console.WriteLine("Area of the circle: " + area);
    }
}