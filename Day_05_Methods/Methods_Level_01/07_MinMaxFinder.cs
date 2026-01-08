using System;

class MinMaxFinder
{
    public static int[] FindSmallestAndLargest(int n1, int n2, int n3)
    {
        int smallest = Math.Min(n1, Math.Min(n2, n3));
        int largest = Math.Max(n1, Math.Max(n2, n3));
        return new int[] { smallest, largest };
    }

    static void Main()
    {
        Console.Write("Enter three numbers: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int[] result = FindSmallestAndLargest(a, b, c);
        Console.WriteLine($"Smallest: {result[0]}, Largest: {result[1]}");
    }
}