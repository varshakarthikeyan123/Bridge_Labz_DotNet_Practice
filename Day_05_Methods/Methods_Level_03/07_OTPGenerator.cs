class OTPGenerator
{
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
            for (int j = i + 1; j < otps.Length; j++)
                if (otps[i] == otps[j]) return false;
        return true;
    }
}
