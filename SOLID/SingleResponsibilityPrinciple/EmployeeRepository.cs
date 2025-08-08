public class EmployeeRepository
{
    public void Save(Employee employee)
    {
        Console.WriteLine($"Employee {employee.Name} saved to database.");
    }
}