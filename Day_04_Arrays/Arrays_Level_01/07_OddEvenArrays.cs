using System;

class OddEvenArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.Error.WriteLine("Invalid input.");
            Environment.Exit(1);
        }

        int[] evenNumbers = new int[number / 2 + 1];
        int[] oddNumbers = new int[number / 2 + 1];

        int evenIndex = 0, oddIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
                evenNumbers[evenIndex++] = i;
            else
                oddNumbers[oddIndex++] = i;
        }

        Console.WriteLine("Even Numbers:");
        for (int i = 0; i < evenIndex; i++)
            Console.Write(evenNumbers[i] + " ");

        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
            Console.Write(oddNumbers[i] + " ");
    }
}
