using System;

class DiscountWithInput
{
    public static void Execute()
    {
        Console.Write("Enter original price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter discount percent: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        double discount = price * discountPercent / 100;
        double finalPrice = price - discount;

        Console.WriteLine($"Discount is {discount} and final price is {finalPrice}");
    }
}
