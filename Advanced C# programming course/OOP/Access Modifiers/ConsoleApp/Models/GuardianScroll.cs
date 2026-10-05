namespace ConsoleApp.Models;

public class GuardianScroll
{
    public string ScrollName {get; set;} = string.Empty;
    private string SecretTechnique {get; set;} = string.Empty;
    protected string SuccessorKnowledge {get; set;} = string.Empty;
    protected internal List<string> AlliancePacts {get; set;} = new List<string>();
}