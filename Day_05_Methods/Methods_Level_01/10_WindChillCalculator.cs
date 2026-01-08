using System;

class WindChillCalculator
{
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        return 35.74 + 0.6215 * temperature +
               (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }

    static void Main()
    {
        Console.Write("Enter temperature: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter wind speed: ");
        double speed = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Wind Chill Temperature: {CalculateWindChill(temp, speed)}");
    }
}
