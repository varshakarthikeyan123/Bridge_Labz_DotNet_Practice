using System;

class KmToMiles
{
    public static void Execute()
    {
        Console.WriteLine("Enter distance in kilometers:");
        double kilometers = Convert.ToDouble(Console.ReadLine());

        double conversionFactor = 1.6;
        double miles = kilometers / conversionFactor;

        Console.WriteLine($"{kilometers} kilometers is equal to {miles} miles.");
    }
}