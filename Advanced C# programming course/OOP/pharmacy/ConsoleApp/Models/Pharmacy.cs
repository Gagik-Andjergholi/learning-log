namespace ConsoleApp.Models;
using System.Text;

public class Pharmacy
{
    string Name;
    private List<Employee> employees;
    private List<Drug> drugs;
    public Pharmacy(string name)
    {
        this.Name = name;
        employees = new List<Employee> {};
        drugs = new List<Drug> {};
    } 

    public void AddDrug(Drug drug)
    {
        this.drugs.Add(drug);
    }

    public void AddEmployee(Employee employee)
    {
        this.employees.Add(employee);
    }

    public int TotalPrice()
    {
        int total = 0;
        foreach(var d in drugs)
            total += d.Amount * d.Price;
        return total;
    }

    public string EmployeeSummary()
    {
        StringBuilder sb = new StringBuilder("Employees:\n", (employees.Count + 1) * 76);
        for(int i = 0; i < employees.Count; i++)
        {
            sb.AppendLine($"The employee number {i + 1} is {employees[i].FirstName} {employees[i].LastName} who is {employees[i].Age} years old.");
        }
        return sb.ToString();
    }
}