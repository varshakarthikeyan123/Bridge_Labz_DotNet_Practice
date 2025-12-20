using System;

class StudentGrades
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int count = int.Parse(Console.ReadLine());

        double[] percentage = new double[count];
        char[] grade = new char[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("Physics: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Chemistry: ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("Maths: ");
            double m = double.Parse(Console.ReadLine());

            percentage[i] = (p + c + m) / 3;

            grade[i] =
                percentage[i] >= 80 ? 'A' :
                percentage[i] >= 70 ? 'B' :
                percentage[i] >= 60 ? 'C' :
                percentage[i] >= 50 ? 'D' :
                percentage[i] >= 40 ? 'E' : 'R';
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Percentage: {percentage[i]}, Grade: {grade[i]}");
        }
    }
}
