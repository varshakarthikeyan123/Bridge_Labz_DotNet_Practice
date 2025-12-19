using System;

class Q7_RectanglePerimeter
{
    public static void Calculate()
    {
        Console.Write("Enter length: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());

        double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter of Rectangle = " + perimeter);
    }
}
