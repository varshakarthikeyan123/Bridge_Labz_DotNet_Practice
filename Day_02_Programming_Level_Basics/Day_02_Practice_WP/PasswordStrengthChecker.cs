using System;

class PasswordStrengthChecker
{
    public static void Main(string[] args)
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        bool hasMinimumLength = password.Length >= 8;
        bool hasDigit = false;
        bool hasSpecialCharacter = false;

        foreach (char character in password)
        {
            if (char.IsDigit(character))
            {
                hasDigit = true;
            }
            else if (!char.IsLetterOrDigit(character))
            {
                hasSpecialCharacter = true;
            }
        }

        if (hasMinimumLength && hasDigit && hasSpecialCharacter)
        {
            Console.WriteLine("Strong");
        }
        else if (hasMinimumLength && (hasDigit || hasSpecialCharacter))
        {
            Console.WriteLine("Medium");
        }
        else
        {
            Console.WriteLine("Weak");
        }
    }
}
