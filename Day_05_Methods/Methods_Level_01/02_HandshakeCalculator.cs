using System;

class HandshakeCalculator
{
    static int CalculateHandshakes(int numberOfStudents)
    {
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int students = Convert.ToInt32(Console.ReadLine());

        int handshakes = CalculateHandshakes(students);
        Console.WriteLine($"Maximum number of handshakes: {handshakes}");
    }
}
