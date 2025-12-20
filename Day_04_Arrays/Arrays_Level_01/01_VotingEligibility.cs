using System;

class VotingEligibility
{
    static void Main(string[] args)
    {
        int[] ages = new int[10];

        // Take age input
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age of student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        // Check voting eligibility
        foreach (int age in ages)
        {
            if (age < 0)
            {
                Console.WriteLine("Invalid age.");
            }
            else if (age >= 18)
            {
                Console.WriteLine($"The student with age {age} can vote.");
            }
            else
            {
                Console.WriteLine($"The student with age {age} cannot vote.");
            }
        }
    }
}
