using System;

class BMIProgram
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int count = int.Parse(Console.ReadLine());

        double[] height = new double[count];
        double[] weight = new double[count];
        double[] bmi = new double[count];
        string[] status = new string[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("Height (m): ");
            height[i] = double.Parse(Console.ReadLine());

            Console.Write("Weight (kg): ");
            weight[i] = double.Parse(Console.ReadLine());

            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] <= 18.4) status[i] = "Underweight";
            else if (bmi[i] <= 24.9) status[i] = "Normal";
            else if (bmi[i] <= 39.9) status[i] = "Overweight";
            else status[i] = "Obese";
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"BMI: {bmi[i]:F2}, Status: {status[i]}");
        }
    }
}
