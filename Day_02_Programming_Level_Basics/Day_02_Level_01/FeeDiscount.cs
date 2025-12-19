using System;

class FeeDiscount
{
    public static void Execute()
    {
        Console.Write("Enter fee amount: ");
        double feeAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        double discountAmount = feeAmount * discountPercent / 100;
        double finalFee = feeAmount - discountAmount;

        Console.WriteLine($"Discount is INR {discountAmount} and final fee is INR {finalFee}");
    }
}
