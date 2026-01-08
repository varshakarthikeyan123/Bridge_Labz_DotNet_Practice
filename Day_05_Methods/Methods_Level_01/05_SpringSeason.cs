using System;

class SpringSeason
{
    static bool IsSpringSeason(int month, int day)
    {
        return (month == 3 && day >= 20) ||
               (month == 4 || month == 5) ||
               (month == 6 && day <= 20);
    }

    static void Main(string[] args)
    {
        int month = Convert.ToInt32(args[0]);
        int day = Convert.ToInt32(args[1]);

        Console.WriteLine(IsSpringSeason(month, day)
            ? "Its a Spring Season"
            : "Not a Spring Season");
    }
}
