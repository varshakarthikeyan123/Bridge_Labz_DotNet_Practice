using System;

class SquareSide
{
    public static void Execute()
    {
        Console.Write("Enter perimeter: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        double side = perimeter / 4;

        Console.WriteLine($"Side length is {side}");
    }
}
