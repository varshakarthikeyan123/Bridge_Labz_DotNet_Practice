using System;

class AthleteRounds
{
    public static void Main(string[] args)
    {
        double side1 = Convert.ToDouble(Console.ReadLine());
        double side2 = Convert.ToDouble(Console.ReadLine());
        double side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double totalDistance = 5000; // meters
        double rounds = totalDistance / perimeter;

        Console.WriteLine($"The total number of rounds the athlete will run is {rounds}");
    }
}
