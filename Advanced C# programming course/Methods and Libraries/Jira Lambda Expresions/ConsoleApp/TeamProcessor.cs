using ConsoleApp.Models;

namespace ConsoleApp;

public class TeamProcessor
{
    private readonly List<TeamMember> _members = new();

    public void SortMembers(Func<TeamMember, TeamMember, int> comparison)
    {
        _members.Sort((TeamMember member1,TeamMember member2) => comparison(member1, member2));
    }

    public List<TeamMember> FilterMembers(Func<TeamMember, bool> condition)
    {
        return _members.Where(member => condition(member)).ToList();
    }

    public void AddMember(TeamMember member)
    {
        _members.Add(member);
    }
}