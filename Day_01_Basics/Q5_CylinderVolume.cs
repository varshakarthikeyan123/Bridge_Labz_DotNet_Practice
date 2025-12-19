using System;
class Q5_CylinderVolume
{
    public static void CalculateVolume()
    {         
        Console.Write("Enter radius of the cylinder: ");
        double radius = double.Parse(Console.ReadLine());
        Console.Write("Enter height of the cylinder: ");
        double height = double.Parse(Console.ReadLine());
        double volume = Math.PI * radius * radius * height;
        Console.WriteLine("Volume of the cylinder: " + volume);
    }
}