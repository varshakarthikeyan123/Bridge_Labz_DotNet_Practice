using System;

class CalendarProgram
{
    // Method to check Leap Year
    static bool IsLeapYear(int year)
    {
        return (year >= 1582) &&
               ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0));
    }

    // Method to get month name
    static string GetMonthName(int month)
    {
        string[] months =
        {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1];
    }

    // Method to get number of days in month
    static int GetDaysInMonth(int month, int year)
    {
        int[] days =
        {
            31, 28, 31, 30, 31, 30,
            31, 31, 30, 31, 30, 31
        };

        if (month == 2 && IsLeapYear(year))
            return 29;

        return days[month - 1];
    }

    // Method to get first day of month (Gregorian Algorithm)
    static int GetFirstDay(int month, int year)
    {
        int d = 1;
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;
        return d0;
    }

    static void Main()
    {
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\n   {GetMonthName(month)} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int firstDay = GetFirstDay(month, year);
        int totalDays = GetDaysInMonth(month, year);

        // First loop for indentation
        for (int i = 0; i < firstDay; i++)
            Console.Write("    ");

        // Second loop to print days
        for (int day = 1; day <= totalDays; day++)
        {
            Console.Write($"{day,3} ");

            if ((day + firstDay) % 7 == 0)
                Console.WriteLine();
        }
    }
}
