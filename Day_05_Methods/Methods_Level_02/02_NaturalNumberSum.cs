using System;

class NaturalNumberSum
{
    static int RecursiveSum(int n)
    {
        if (n == 0) return 0;
        return n + RecursiveSum(n - 1);
    }

    static int FormulaSum(int n)
    {
        return n * (n + 1) / 2;
    }

    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        int recursiveResult = RecursiveSum(n);
        int formulaResult = FormulaSum(n);

        Console.WriteLine($"Recursive Sum: {recursiveResult}");
        Console.WriteLine($"Formula Sum: {formulaResult}");
        Console.WriteLine(recursiveResult == formulaResult ? "Results Match" : "Results Do Not Match");
    }
}
