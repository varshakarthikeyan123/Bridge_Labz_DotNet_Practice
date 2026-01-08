using System;

class FriendsComparison
{
    static int FindYoungest(int[] ages)
    {
        return Math.Min(ages[0], Math.Min(ages[1], ages[2]));
    }

    static double FindTallest(double[] heights)
    {
        return Math.Max(heights[0], Math.Max(heights[1], heights[2]));
    }

    static void Main()
    {
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of friend {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height of friend {i + 1}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine($"Youngest Age: {FindYoungest(ages)}");
        Console.WriteLine($"Tallest Height: {FindTallest(heights)}");
    }
}
