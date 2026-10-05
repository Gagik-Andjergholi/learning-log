namespace ConsoleApp.Models;

public class WarriorScroll :GuardianScroll
{
    internal void AddAlliancePact(string pact)
    {
        AlliancePacts.Add(pact);
    }
}