using ClassExerciseClassLibrary;
using System;

namespace ClassExerciseConsoleApplication;
class Program
{
    private static Company company;
    static void Main(string[] args)
    {
        GetCompanyFromConsoleInput();
        WriteCompanyInfoAndWaitForKeypress();
    }

    private static void GetCompanyFromConsoleInput()
    {
        Console.Write("Please enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Please enter number of employees: ");
        string numberOfEmployeesString = Console.ReadLine();
        if (!int.TryParse(numberOfEmployeesString, out int numberOfEmployees))
        {
            Console.WriteLine($"Unable to parse '{numberOfEmployeesString}' to an int. Using default 0");
        }

        Console.Write("Please enter whether company is government run: (Y/N)");
        string governmentRunString = Console.ReadLine();
        bool governmentRun = false;
        if (!governmentRunString.Contains("n", StringComparison.InvariantCultureIgnoreCase)) { governmentRun = true; }
        else if (governmentRunString.Contains("n", StringComparison.InvariantCultureIgnoreCase)) { governmentRun = false; }
        else
        {
            Console.WriteLine("Unable to understand input. Government run will be set to false.");
        }
        company = new Company(companyName, numberOfEmployees, governmentRun); 
    }

    private static void WriteCompanyInfoAndWaitForKeypress()
    {
        Console.WriteLine();
        Console.WriteLine("Company created:");
        Console.WriteLine(company);
        Console.WriteLine("Any key to exit");
        Console.ReadKey();
    }
}