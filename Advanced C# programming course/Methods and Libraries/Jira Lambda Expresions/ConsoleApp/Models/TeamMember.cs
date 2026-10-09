namespace ConsoleApp.Models;

public class TeamMember
{
    public string Name { get; set; }
    public int TasksCompleted { get; set; }
    public int YearsOfExperience { get; set; }

    public TeamMember(string name, int tasksCompleted, int yearsOfExperience)
    {
        Name = name;
        TasksCompleted = tasksCompleted;
        YearsOfExperience = yearsOfExperience;
    }

    
}