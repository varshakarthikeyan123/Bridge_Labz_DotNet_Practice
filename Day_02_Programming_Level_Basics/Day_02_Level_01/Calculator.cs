using System;

class Calculator
{
    public static void Execute()
    {
        Console.Write("Enter first number: ");
        double numberOne = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double numberTwo = Convert.ToDouble(Console.ReadLine());

        double addition = numberOne + numberTwo;
        double subtraction = numberOne - numberTwo;
        double multiplication = numberOne * numberTwo;
        double division = numberOne / numberTwo;

        Console.WriteLine(
            $"Add: {addition}, Sub: {subtraction}, Mul: {multiplication}, Div: {division}"
        );
    }
}
