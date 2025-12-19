using System;

class AccessCheck
{
    public static void Main(string[] args)
    {
        User user = new User
        {
            IsActive = true,
            HasPermission = true
        };

        if (user == null) return;
        if (!user.IsActive) return;
        if (!user.HasPermission) return;

        Console.WriteLine("Access Granted");
    }
}

class User
{
    public bool IsActive { get; set; }
    public bool HasPermission { get; set; }
}
