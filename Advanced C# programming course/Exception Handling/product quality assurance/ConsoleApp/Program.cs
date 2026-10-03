namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        Examiner ex = new Examiner();
        List<Product> products = new List<Product>()
        {
            new Product(1, 80, 1200, 240), 
            new Product(2, 70, 900, 239), 
            new Product(3, 70, 1000, 210), 
            new Product(4, 70, 1200, 238)
        };
        List<string> output = ex.CheckProductList(products);
        foreach (var p in output)
        {
            Console.WriteLine(p);
        }
        /*
        1-SizeException
        2-PressureToleranceException
        3-ColorTransparencyException
        */
    }
}