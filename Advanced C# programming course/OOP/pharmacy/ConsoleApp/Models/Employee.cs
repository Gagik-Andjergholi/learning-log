namespace ConsoleApp.Models;

public class Employee
{
    public string FirstName;
    public string LastName;
    public int Age;

    public Employee(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }
}