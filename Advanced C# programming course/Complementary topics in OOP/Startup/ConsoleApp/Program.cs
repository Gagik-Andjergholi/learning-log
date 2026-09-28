namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        TradeRecord T1 = new TradeRecord(12, 2000);
        TradeRecord T2 = new TradeRecord(50, 10);
        TradeRecord T3 = new TradeRecord(50, 20);

        System.Console.WriteLine(T1 == T1);
        System.Console.WriteLine(T1 == T2);
        System.Console.WriteLine(T1 != T2);
        System.Console.WriteLine(T3 == T2);

        System.Console.WriteLine(T1.ToString());
        System.Console.WriteLine(T2.ToString());
        System.Console.WriteLine(T3.ToString());

        var T4 = T3 + T2;
        System.Console.WriteLine(T4.ToString());

        T4 = T3 - T1;
        System.Console.WriteLine(T4.ToString());
    }
}
