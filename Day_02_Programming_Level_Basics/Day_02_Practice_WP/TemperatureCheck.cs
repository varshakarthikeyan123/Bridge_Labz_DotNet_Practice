using System;

class TemperatureCheck
{
    public static void Main(string[] args)
    {
        Console.Write("Enter temperature: ");
        int temperature = Convert.ToInt32(Console.ReadLine());

        if (temperature < 0)
        {
            Console.WriteLine("Freezing");
        }
        else if (temperature <= 20)
        {
            Console.WriteLine("Cold");
        }
        else if (temperature <= 35)
        {
            Console.WriteLine("Warm");
        }
        else
        {
            Console.WriteLine("Hot");
        }
    }
}
