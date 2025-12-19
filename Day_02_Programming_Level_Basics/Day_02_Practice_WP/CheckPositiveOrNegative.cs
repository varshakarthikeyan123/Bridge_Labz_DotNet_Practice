using System;

class CheckPositiveOrNegative
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sign = Math.Sign(number);

        string result =
            sign == 1 ? "Positive" :
            sign == -1 ? "Negative" :
            "Zero";

        Console.WriteLine($"The number {number} is {result}");
    }
}
