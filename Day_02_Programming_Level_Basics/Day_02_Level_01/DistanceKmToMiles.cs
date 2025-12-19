using System;

class DistanceKmToMiles
{
    public static void Execute()
    {
        Console.Write("Enter kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());

        double miles = km / 1.6;

        Console.WriteLine($"Miles = {miles}");
    }
}
