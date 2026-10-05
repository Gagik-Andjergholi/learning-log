namespace ConsoleApp.Models;

public class MageScroll : GuardianScroll
{
    internal void AddAlliancePact(string pact)
    {
        AlliancePacts.Add(pact);
    }
}