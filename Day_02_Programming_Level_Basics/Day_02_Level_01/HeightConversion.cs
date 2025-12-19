using System;

class HeightConversion
{
    public static void Execute()
    {
        Console.Write("Enter height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double totalInches = heightCm / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;

        Console.WriteLine($"Height is {feet} feet and {inches} inches");
    }
}
