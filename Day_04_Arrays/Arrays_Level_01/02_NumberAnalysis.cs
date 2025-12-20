using System;

class NumberAnalysis
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        // Input values
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Analyze numbers
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                Console.WriteLine(num % 2 == 0 ? $"{num} is Positive and Even" : $"{num} is Positive and Odd");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }

        // Compare first and last elements
        if (numbers[0] == numbers[^1])
            Console.WriteLine("First and last elements are equal.");
        else if (numbers[0] > numbers[^1])
            Console.WriteLine("First element is greater than last.");
        else
            Console.WriteLine("First element is less than last.");
    }
}
