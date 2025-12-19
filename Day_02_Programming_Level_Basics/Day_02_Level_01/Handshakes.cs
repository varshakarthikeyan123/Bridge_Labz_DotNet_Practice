using System;

class Handshakes
{
    public static void Execute()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine($"Maximum handshakes possible is {handshakes}");
    }
}
