namespace ClassExerciseClassLibrary;
public class Company
{
    public string Name { get; set; }
    public int NumberOfEmployees { get; set; }
    public bool GovernmentRun { get; set; }

    public Company(string name, int numberOfEmployees = 0, bool governmentRun = false)
    {
        Name = name;
        NumberOfEmployees = numberOfEmployees;
        GovernmentRun = governmentRun;
    }


    public override string ToString()
    {
        return $"This company is named {Name}, has {NumberOfEmployees} employees and is{(GovernmentRun ? " ": " not ")}government run";
    }
}