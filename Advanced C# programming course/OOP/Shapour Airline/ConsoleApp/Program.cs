using ConsoleApp.Models;

namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        var car = new Vehicle("saipa motmaen", -1, 4, 10);
        var UFO = new FlyingVehicle("UFO", int.MaxValue, 1, int.MaxValue, "anti matter", 0, 0, "nope");
        var airplain = new Airplane("Boeing 737", 106000000, 162, 876, "Jet A-1", 3, 6, "Yoke", "Luftanza", 6, "Captain jean luc picard");
        var b = new B707 ("Boeing 707-320B", 4300000.1m, 141, 1010, "Jet A-1", 1, 10, "Yoke", "Mahan Air", 4, "Captain jack sparrow");

        System.Console.WriteLine(car.Name);
        System.Console.WriteLine(UFO.Name);
        System.Console.WriteLine(airplain.Name);
        System.Console.WriteLine(b.Name);
    }
}
