class FactorUtilities
{
    public static int[] FindFactors(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0) count++;

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= n; i++)
            if (n % i == 0) factors[index++] = i;

        return factors;
    }

    public static bool IsPerfect(int n, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            if (f != n) sum += f;
        return sum == n;
    }

    public static bool IsAbundant(int n, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            if (f != n) sum += f;
        return sum > n;
    }

    public static bool IsDeficient(int n, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            if (f != n) sum += f;
        return sum < n;
    }

    public static bool IsStrong(int n)
    {
        int temp = n, sum = 0;
        while (temp > 0)
        {
            int d = temp % 10;
            int fact = 1;
            for (int i = 1; i <= d; i++) fact *= i;
            sum += fact;
            temp /= 10;
        }
        return sum == n;
    }
}
