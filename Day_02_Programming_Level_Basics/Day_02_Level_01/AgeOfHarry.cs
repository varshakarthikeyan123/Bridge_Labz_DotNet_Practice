using System;

class AgeOfHarry
{
    public static void Execute()
    {
        string name = "Harry";
        int birthYear = 2000;
        int currentYear = 2024;

        int age = currentYear - birthYear;

        Console.WriteLine($"{name} is {age} years old in the year {currentYear}.");

    }
}
