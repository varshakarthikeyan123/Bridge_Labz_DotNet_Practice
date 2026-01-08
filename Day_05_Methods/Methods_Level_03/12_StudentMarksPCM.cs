using System;

class StudentMarksPCM
{
    // Method to generate random PCM marks
    static int[,] GeneratePCMMarks(int students)
    {
        Random random = new Random();
        int[,] marks = new int[students, 3];

        for (int i = 0; i < students; i++)
        {
            marks[i, 0] = random.Next(10, 100); // Physics
            marks[i, 1] = random.Next(10, 100); // Chemistry
            marks[i, 2] = random.Next(10, 100); // Maths
        }
        return marks;
    }

    // Method to calculate total, average, percentage
    static double[,] CalculateResults(int[,] marks)
    {
        int students = marks.GetLength(0);
        double[,] results = new double[students, 3];

        for (int i = 0; i < students; i++)
        {
            double total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            double average = total / 3;
            double percentage = (total / 300) * 100;

            results[i, 0] = Math.Round(total, 2);
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }
        return results;
    }

    // Method to display scorecard
    static void DisplayScoreCard(int[,] marks, double[,] results)
    {
        Console.WriteLine("Stu\tPhysics\tChem\tMaths\tTotal\tAverage\tPercentage");
        Console.WriteLine("-------------------------------------------------------------");

        for (int i = 0; i < marks.GetLength(0); i++)
        {
            Console.WriteLine($"{i + 1}\t{marks[i, 0]}\t{marks[i, 1]}\t{marks[i, 2]}\t{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}");
        }
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int students = Convert.ToInt32(Console.ReadLine());

        int[,] pcmMarks = GeneratePCMMarks(students);
        double[,] results = CalculateResults(pcmMarks);

        DisplayScoreCard(pcmMarks, results);
    }
}
