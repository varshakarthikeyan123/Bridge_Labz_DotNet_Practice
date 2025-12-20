using System;

class StudentGrades2D
{
    static void Main()
    {
        Console.Write("Enter students count: ");
        int n = int.Parse(Console.ReadLine());

        double[,] marks = new double[n, 3];
        double[] percentage = new double[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3; j++)
                marks[i, j] = double.Parse(Console.ReadLine());

            percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"Percentage: {percentage[i]}");
    }
}
