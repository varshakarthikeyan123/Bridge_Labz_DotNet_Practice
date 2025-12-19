using System;

class ATMWithdrawal
{
    public static void Main(string[] args)
    {
        // Constants
        int minimumBalance = 1000;
        int dailyLimit = 20000;

        // Inputs
        Console.Write("Enter account balance: ");
        int balance = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter withdrawal amount: ");
        int withdrawalAmount = Convert.ToInt32(Console.ReadLine());

        // Nested if logic
        if (balance - withdrawalAmount >= minimumBalance)
        {
            if (withdrawalAmount <= dailyLimit)
            {
                Console.WriteLine("Withdrawal Approved");
            }
            else
            {
                Console.WriteLine("Withdrawal Rejected: Daily limit exceeded");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal Rejected: Insufficient balance (Minimum balance required is ₹1000)");
        }
    }
}
