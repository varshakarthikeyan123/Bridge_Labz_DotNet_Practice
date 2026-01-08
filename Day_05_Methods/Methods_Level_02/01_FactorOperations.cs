using System;

class FactorOperations
{
    static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
            if (number % i == 0)
                count++;

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++)
            if (number % i == 0)
                factors[index++] = i;

        return factors;
    }

    static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            sum += f;
        return sum;
    }

    static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int f in factors)
            product *= f;
        return product;
    }

    static double SumOfSquares(int[] factors)
    {
        double sum = 0;
        foreach (int f in factors)
            sum += Math.Pow(f, 2);
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("Factors:");
        foreach (int f in factors)
            Console.Write(f + " ");

        Console.WriteLine($"\nSum: {SumOfFactors(factors)}");
        Console.WriteLine($"Product: {ProductOfFactors(factors)}");
        Console.WriteLine($"Sum of Squares: {SumOfSquares(factors)}");
    }
}
