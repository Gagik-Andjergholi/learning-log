using ConsoleApp.Models;

namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        List<Drug> drugs = new List<Drug>
        {
            new Drug(name : "Methamphetamine", amount : 1, price : 10000000),
            new Drug(name : "LSD", amount : 5, price : 20000000),
            new Drug(name : "Advil", amount : 10, price : 20),
            new Drug(name : "ibuprofen ", amount : 0, price : 0),
            new Drug(name : "Antihistamines", amount : 73, price : 1),
            new Drug(name : "Adult Cold", amount : 100, price : 33333),
            new Drug(name : "Vitamin C", amount : 100, price : 33333)
        };

        List<Employee> employees = new List<Employee>
        {
            new Employee(firstName : "muhamad", lastName : "bin salman", age : 41),
            new Employee(firstName : "khaled", lastName : "kashmiri", age : 32),
            new Employee(firstName : "abu", lastName : "sina", age : 56),
            new Employee(firstName : "Alexander", lastName : "Fleming", age : 73),
            new Employee(firstName : "barak", lastName : "obama", age : 60)
        };
        
        Pharmacy rasel = new Pharmacy(name : "rasel");

        Console.WriteLine(rasel.TotalPrice());
        foreach(var d in drugs)
        {
            rasel.AddDrug(d);
            Console.WriteLine(rasel.TotalPrice());
        }

        Console.WriteLine(rasel.EmployeeSummary());
        foreach(var e in employees)
        {
            rasel.AddEmployee(e);
            Console.WriteLine(rasel.EmployeeSummary());
        }
    }
}
