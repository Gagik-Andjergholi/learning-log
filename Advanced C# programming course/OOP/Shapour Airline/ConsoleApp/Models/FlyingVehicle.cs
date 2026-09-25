namespace ConsoleApp.Models;

public class FlyingVehicle : Vehicle
{
    public string Fuel;
    public int NumberOfFins;
    public int NumberOfWheels;
    public string SteeringWheel;

    public FlyingVehicle(string name,
                        decimal price,
                        int numberOfSeats,
                        int maxspeed,
                        string fuel,
                        int numberOfFins,
                        int numberOfWheels,
                        string steeringWheel) : base(name, price, numberOfSeats, maxspeed)
    {
        this.Fuel = fuel;
        this.NumberOfFins = numberOfFins;
        this.NumberOfWheels = numberOfWheels;
        this.SteeringWheel = steeringWheel;
    }
}