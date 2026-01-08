using System;

class EmployeeBonusSystem
{
    // Method to generate salary and years of service
    static double[,] GenerateEmployeeData(int employees)
    {
        Random random = new Random();
        double[,] data = new double[employees, 2];

        for (int i = 0; i < employees; i++)
        {
            data[i, 0] = random.Next(10000, 100000); // Salary
            data[i, 1] = random.Next(1, 11);         // Years of Service
        }
        return data;
    }

    // Method to calculate bonus and new salary
    static double[,] CalculateBonus(double[,] data)
    {
        int employees = data.GetLength(0);
        double[,] result = new double[employees, 2];

        for (int i = 0; i < employees; i++)
        {
            double salary = data[i, 0];
            double years = data[i, 1];

            double bonusRate = years > 5 ? 0.05 : 0.02;
            double bonus = salary * bonusRate;
            double newSalary = salary + bonus;

            result[i, 0] = bonus;
            result[i, 1] = newSalary;
        }
        return result;
    }

    // Method to display data in table format
    static void DisplayTable(double[,] data, double[,] result)
    {
        double totalOldSalary = 0, totalBonus = 0, totalNewSalary = 0;

        Console.WriteLine("Emp\tOldSalary\tYears\tBonus\t\tNewSalary");
        Console.WriteLine("--------------------------------------------------------");

        for (int i = 0; i < data.GetLength(0); i++)
        {
            Console.WriteLine($"{i + 1}\t{data[i, 0]}\t\t{data[i, 1]}\t{result[i, 0]}\t\t{result[i, 1]}");

            totalOldSalary += data[i, 0];
            totalBonus += result[i, 0];
            totalNewSalary += result[i, 1];
        }

        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine($"TOTAL\t{totalOldSalary}\t\t\t{totalBonus}\t\t{totalNewSalary}");
    }

    static void Main()
    {
        int employees = 10;

        double[,] employeeData = GenerateEmployeeData(employees);
        double[,] bonusData = CalculateBonus(employeeData);

        DisplayTable(employeeData, bonusData);
    }
}
