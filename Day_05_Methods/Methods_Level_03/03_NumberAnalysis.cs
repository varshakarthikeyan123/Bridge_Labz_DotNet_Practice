class NumberAnalysis
{
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits) sum += d;
        return sum;
    }

    public static double SumOfSquares(int[] digits)
    {
        double sum = 0;
        foreach (int d in digits)
            sum += Math.Pow(d, 2);
        return sum;
    }

    public static bool IsHarshad(int number, int[] digits)
    {
        return number % SumOfDigits(digits) == 0;
    }

    public static int[,] DigitFrequency(int[] digits)
    {
        int[,] freq = new int[10, 2];

        for (int i = 0; i < 10; i++)
            freq[i, 0] = i;

        foreach (int d in digits)
            freq[d, 1]++;

        return freq;
    }
}
