using System;

class Q9_AverageOfThreeNumbers
{
    public static void Calculate()
    {
        Console.Write("Enter first number: ");
        double first = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double second = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double third = double.Parse(Console.ReadLine());

        double average = (first + second + third) / 3;
        Console.WriteLine("Average = " + average);
    }
}
