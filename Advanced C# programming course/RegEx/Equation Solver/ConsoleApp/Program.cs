namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Calculator.Solve("100 + 50 = #50")); 
        // Output: "100 + 50 = 150"
        Console.WriteLine(Calculator.Solve("15 + 1#2 = 136"));
        // Output: "-1"
        Console.WriteLine(Calculator.Solve("# + 1 = 2")); 
        // Output: "1 + 1 = 2"
        Console.WriteLine(Calculator.Solve("# + 1 = 20")); 
        // Output: "-1"
        Console.WriteLine(Calculator.Solve("9 + # = 18")); 
        // Output: "9 + 9 = 18"
        Console.WriteLine(Calculator.Solve(@"100 + 900 = #000")); 
        // Output: "100 + 900 = 1000"
        Console.WriteLine(Calculator.Solve("1#4 + 23 = 37")); 
        // Output: "14 + 23 = 37"
        Console.WriteLine(Calculator.Solve("# + 0 = 13468")); 
        // Output: "13468 + 0 = 13468"
        Console.WriteLine(Calculator.Solve("73 + 4# = 470")); 
        // Output: "-1"
        Console.WriteLine(Calculator.Solve("568865161 + 1#3 = 701354304")); 
        // Output: "568865161 + 132489143 = 701354304"
    }
}
