using System;

class FeetConversion
{
    public static void Execute()
    {
        Console.Write("Enter distance in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());

        double yards = feet / 3;
        double miles = yards / 1760;

        Console.WriteLine($"Distance is {yards} yards and {miles} miles");
    }
}
