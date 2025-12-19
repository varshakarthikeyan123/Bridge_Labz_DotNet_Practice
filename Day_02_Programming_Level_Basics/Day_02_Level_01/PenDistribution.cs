using System;

class PenDistribution
{
    public static void Execute()
    {
        Console.Write("Enter total pens: ");
        int totalPens = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int pensPerStudent = totalPens / numberOfStudents;
        int remainingPens = totalPens % numberOfStudents;

        Console.WriteLine($"Each student gets {pensPerStudent} pens and remaining pens are {remainingPens}");
    }
}
