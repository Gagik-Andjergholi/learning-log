namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        var results = RealNumberHelper.Check(new List<string> { "1.5e+2", "3.", "1.1.1", "1+e5", 
        "-3.14E-10", "  -100.e10", ".001", " -0.0E-100", "+2.7818E" });
        foreach (var result in results)
            Console.WriteLine(result);
        // Output: LEGAL, ILLEGAL, ILLEGAL, ILLEGAL, LEGAL, ILLEGAL, ILLEGAL, LEGAL, LEGAL
    }
}