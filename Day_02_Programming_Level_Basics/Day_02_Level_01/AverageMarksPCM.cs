using System;

class AverageMarksPCM
{
    public static void Execute()
    {
        Console.WriteLine("Enter the name of the student:");
        string name = Console.ReadLine();
        
        Console.WriteLine("Enter marks for Physics:");
        int physicsMarks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks for Chemistry:");
        int chemistryMarks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks for Maths:");
        int mathsMarks = Convert.ToInt32(Console.ReadLine());

        int totalMarks = physicsMarks + chemistryMarks + mathsMarks;
        double average = totalMarks / 3.0;

        Console.WriteLine($"{name}'s average marks is {average} in PCM.");

    }
}