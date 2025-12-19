using System;

class EarthVolume
{
    public static void Execute()
    {
        Console.Write("Enter radius of earth in km: ");
        double earthRadiusKm = Convert.ToDouble(Console.ReadLine());

        double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(earthRadiusKm, 3);
        double volumeMiles = volumeKm / Math.Pow(1.6, 3);

        Console.WriteLine($"Earth volume is {volumeKm} km³ and {volumeMiles} miles³");
    }
}
