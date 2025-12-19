using System;

class PurchaseTotal
{
    public static void Execute()
    {
        Console.Write("Enter unit price: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        double totalPrice = unitPrice * quantity;

        Console.WriteLine($"Total purchase price is INR {totalPrice}");
    }
}
