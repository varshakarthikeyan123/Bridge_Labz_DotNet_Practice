using System;

class BMI2D
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int number = int.Parse(Console.ReadLine());

        double[,] personData = new double[number, 3]; // height, weight, bmi
        string[] status = new string[number];

        for (int i = 0; i < number; i++)
        {
            Console.Write("Height: ");
            personData[i, 0] = double.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            personData[i, 1] = double.Parse(Console.ReadLine());

            personData[i, 2] = personData[i, 1] /
                               (personData[i, 0] * personData[i, 0]);

            double bmi = personData[i, 2];

            status[i] = bmi <= 18.4 ? "Underweight" :
                        bmi <= 24.9 ? "Normal" :
                        bmi <= 39.9 ? "Overweight" : "Obese";
        }

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"BMI: {personData[i, 2]:F2}, Status: {status[i]}");
        }
    }
}
