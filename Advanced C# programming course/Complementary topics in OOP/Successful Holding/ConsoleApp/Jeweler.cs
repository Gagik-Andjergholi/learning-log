using ConsoleApp.Infra;

namespace ConsoleApp;

public class Jeweler : Craftsman
{
    //TODO: complete the implementation
    public override string CraftsmanSkill()
    {
        return "The Jeweler crafts a radiant diamond ring";
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