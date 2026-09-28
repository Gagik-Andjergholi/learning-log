using ConsoleApp.Infra;

namespace ConsoleApp;

public class Potter : Craftsman
{
    //TODO: complete the implementation
    public override string CraftsmanSkill()
    {
        return "The Potter shapes a beautiful vase";
    }

    public override void CreateItem()
    {
        System.Console.WriteLine($"I am a {GetType()} and i make thinks go BRRRRR");
    }

    public override void DisplayItem()
    {
        System.Console.WriteLine($"I am a {GetType()} and i make thinks go BRRRRR");
    }

    public override void SellItem()
    {
        System.Console.WriteLine($"I am a {GetType()} and i make thinks go BRRRRR");
    }
}