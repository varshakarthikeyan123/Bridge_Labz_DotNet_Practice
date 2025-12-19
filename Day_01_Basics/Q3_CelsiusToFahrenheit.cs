using System;

class Q3_CelsiusToFahrenheit
{
    public static void Convert()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
    }
}