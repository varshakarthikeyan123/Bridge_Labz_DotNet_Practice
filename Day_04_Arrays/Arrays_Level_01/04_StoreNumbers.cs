using System;

class StoreNumbers
{
    static void Main(string[] args)
    {
        double[] values = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            Console.Write("Enter a number: ");
            double input = double.Parse(Console.ReadLine());

            if (input <= 0 || index == values.Length)
                break;

            values[index++] = input;
        }

        for (int i = 0; i < index; i++)
        {
            total += values[i];
        }

        Console.WriteLine($"Total sum: {total}");
    }
}
