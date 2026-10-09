using ConsoleApp.Models;

namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        TeamProcessor team = new();

        team.AddMember(new TeamMember("Anna", 35, 3));
        team.AddMember(new TeamMember("Gagik", 12, 1));
        team.AddMember(new TeamMember("Aram", 60, 5));
        team.AddMember(new TeamMember("Sara", 8, 0));
        team.AddMember(new TeamMember("David", 42, 3));
        team.AddMember(new TeamMember("Mariam", 25, 2));
        team.AddMember(new TeamMember("John", 75, 8));
        team.AddMember(new TeamMember("Nina", 18, 1));
        team.AddMember(new TeamMember("Alex", 50, 5));
        team.AddMember(new TeamMember("Lilit", 30, 2));

        // Always true: every member passes the filter.
        PrintMembers("All members", team.FilterMembers(m => true));

        // Sort by experience, lowest first.
        Func<TeamMember, TeamMember, int> comparer =
            (m1, m2) => m1.YearsOfExperience.CompareTo(m2.YearsOfExperience);

        team.SortMembers(comparer);
        PrintMembers("Sorted by experience", team.FilterMembers(m => true));

        // Filter using a delegate stored in a variable.
        Func<TeamMember, bool> experienced =
            m => m.YearsOfExperience >= 3;

        PrintMembers("Experienced members", team.FilterMembers(experienced));

        // Filter using a lambda passed directly.
        PrintMembers("30+ tasks, at most 3 years of experience",
            team.FilterMembers(m =>
                m.TasksCompleted >= 30 && m.YearsOfExperience <= 3));

        // Reverse the comparison to sort highest first.
        team.SortMembers((m1, m2) =>
            m2.TasksCompleted.CompareTo(m1.TasksCompleted));

        PrintMembers("Sorted by tasks, highest first",
            team.FilterMembers(m => true));

        // Add your experiments here!
    }

    static void PrintMembers(string title, List<TeamMember> members)
    {
        Console.WriteLine($"\n{title}");

        foreach (TeamMember m in members)
        {
            Console.WriteLine(
                $"{m.Name,-10} Tasks: {m.TasksCompleted,3}  Experience: {m.YearsOfExperience}");
        }
    }
}