using System;

class ProfitLoss
{
    public static void Execute()
    {
        Console.Write("Enter cost price: ");
        double costPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter selling price: ");
        double sellingPrice = Convert.ToDouble(Console.ReadLine());

        double profit = sellingPrice - costPrice;
        double profitPercentage = (profit / costPrice) * 100;

        Console.WriteLine(
            $"Profit is INR {profit} and Profit Percentage is {profitPercentage}"
        );
    }
}
