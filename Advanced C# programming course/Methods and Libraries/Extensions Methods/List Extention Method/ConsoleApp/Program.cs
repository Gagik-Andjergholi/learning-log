namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        List<int> a = new List<int> {1, 2};
        System.Console.WriteLine(a.GetAverageScore());
        System.Console.WriteLine(a.GetHighestScore());
        System.Console.WriteLine(a.DidAllStudentsPass());
    }
}
