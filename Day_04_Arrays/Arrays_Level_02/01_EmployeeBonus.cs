using System;

class EmployeeBonus
{
    static void Main()
    {
        const int employeeCount = 10;

        double[] salaries = new double[employeeCount];
        double[] yearsOfService = new double[employeeCount];
        double[] bonuses = new double[employeeCount];
        double[] newSalaries = new double[employeeCount];

        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        // Input salary and years of service
        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine($"Employee {i + 1}");

            Console.Write("Enter Salary: ");
            if (!double.TryParse(Console.ReadLine(), out salaries[i]) || salaries[i] <= 0)
            {
                Console.Error.WriteLine("Invalid salary. Re-enter.");
                i--;
                continue;
            }

            Console.Write("Enter Years of Service: ");
            if (!double.TryParse(Console.ReadLine(), out yearsOfService[i]) || yearsOfService[i] < 0)
            {
                Console.Error.WriteLine("Invalid years of service. Re-enter.");
                i--;
                continue;
            }
        }

        // Bonus calculation
        for (int i = 0; i < employeeCount; i++)
        {
            bonuses[i] = (yearsOfService[i] > 5) ? salaries[i] * 0.05 : salaries[i] * 0.02;
            newSalaries[i] = salaries[i] + bonuses[i];

            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        Console.WriteLine($"\nTotal Bonus Paid: {totalBonus}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
    }
}
