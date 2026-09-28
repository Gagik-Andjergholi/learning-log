using ConsoleApp.Models;

namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        var shah = new Shah();
        var div = new Div();
        var goul = new Ghoul();
        var huma = new Huma();
        var simorgh = new Simorgh();
        System.Console.WriteLine(shah.CommandCreatureToPerformMagic(div));
        System.Console.WriteLine(shah.CommandCreatureToPerformMagic(goul));
        System.Console.WriteLine(shah.CommandCreatureToPerformMagic(huma));
        System.Console.WriteLine(shah.CommandCreatureToPerformMagic(simorgh));
    }
}
