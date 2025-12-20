using System;

class FriendsAgeHeight
{
    static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {names[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write($"Enter height of {names[i]}: ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;

            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }

        Console.WriteLine($"Youngest: {names[youngestIndex]}");
        Console.WriteLine($"Tallest: {names[tallestIndex]}");
    }
}
