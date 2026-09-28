namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        var p = new Potter();
        var j = new Jeweler();
        var b = new Blacksmith();
        System.Console.WriteLine(p.CraftsmanSkill());
        System.Console.WriteLine(j.CraftsmanSkill());
        System.Console.WriteLine(b.CraftsmanSkill());

        p.CreateItem();
        j.DisplayItem();
        b.SellItem();
    }
}
