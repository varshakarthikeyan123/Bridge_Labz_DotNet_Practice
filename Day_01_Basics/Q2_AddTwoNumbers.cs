using System;

class Q2_AddTwoNumbers
{
    public static void CalculateSum()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum = " + (a + b));
    }
}
