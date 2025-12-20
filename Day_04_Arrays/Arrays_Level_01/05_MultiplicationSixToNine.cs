using System;

class MultiplicationSixToNine
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] results = new int[4];
        int index = 0;

        for (int i = 6; i <= 9; i++)
        {
            results[index++] = number * i;
        }

        for (int i = 6, j = 0; i <= 9; i++, j++)
        {
            Console.WriteLine($"{number} * {i} = {results[j]}");
        }
    }
}
