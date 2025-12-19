using System;

class FoodOrderCheck
{
    public static void Main(string[] args)
    {
        Console.Write("Is restaurant open? (true/false): ");
        bool isRestaurantOpen = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Is delivery partner available? (true/false): ");
        bool isDeliveryPartnerAvailable = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Enter order amount: ");
        int orderAmount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Is customer Prime? (true/false): ");
        bool isPrimeCustomer = Convert.ToBoolean(Console.ReadLine());

        bool isOrderAccepted =
            isRestaurantOpen &&
            isDeliveryPartnerAvailable &&
            (orderAmount >= 200 || isPrimeCustomer);

        if (isOrderAccepted)
        {
            Console.WriteLine("Order Accepted");
        }
        else
        {
            Console.WriteLine("Order Rejected");
        }
    }
}
