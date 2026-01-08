using System;

class NumberChecker
{
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }

    public static int[] GetDigits(int number)
    {
        char[] chars = number.ToString().ToCharArray();
        int[] digits = new int[chars.Length];
        for (int i = 0; i < chars.Length; i++)
            digits[i] = chars[i] - '0';
        return digits;
    }

    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int d in digits)
            if (d != 0) return true;
        return false;
    }

    public static bool IsArmstrong(int number, int[] digits)
    {
        int power = digits.Length;
        int sum = 0;
        foreach (int d in digits)
            sum += (int)Math.Pow(d, power);
        return sum == number;
    }

    public static int[] FindLargestAndSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int d in digits)
        {
            if (d > largest)
            {
                secondLargest = largest;
                largest = d;
            }
            else if (d > secondLargest && d != largest)
                secondLargest = d;
        }
        return new int[] { largest, secondLargest };
    }

    public static int[] FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        foreach (int d in digits)
        {
            if (d < smallest)
            {
                secondSmallest = smallest;
                smallest = d;
            }
            else if (d < secondSmallest && d != smallest)
                secondSmallest = d;
        }
        return new int[] { smallest, secondSmallest };
    }
}
