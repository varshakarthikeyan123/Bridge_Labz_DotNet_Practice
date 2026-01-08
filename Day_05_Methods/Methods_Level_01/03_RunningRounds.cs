using System;

class RunningRounds
{
    static double CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        return 5000 / perimeter;
    }

    static void Main()
    {
        Console.Write("Enter side 1: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double rounds = CalculateRounds(a, b, c);
        Console.WriteLine($"Number of rounds needed to complete 5 km: {rounds}");
    }
}
