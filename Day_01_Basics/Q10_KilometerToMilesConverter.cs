using System;

class Q10_KilometerToMilesConverter
{
    public static void Convert()
    {
        Console.Write("Enter distance in Kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());

        double miles = kilometers * 0.621371;
        Console.WriteLine("Distance in Miles = " + miles);
    }
}
