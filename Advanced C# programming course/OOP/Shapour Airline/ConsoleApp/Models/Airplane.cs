namespace ConsoleApp.Models;

public class Airplane : FlyingVehicle
{
    public string Airline;
    public int NumberOfCrew;
    public string Captain;

    public Airplane(string name,
                        decimal price,
                        int numberOfSeats,
                        int maxspeed,
                        string fuel,
                        int numberOfFins,
                        int numberOfWheels,
                        string steeringWheel,
                        string airline,
                        int numberOfCrew,
                        string captain) : base(name, price, numberOfSeats, maxspeed, fuel, numberOfFins, numberOfWheels, steeringWheel)
    {
        this.Airline = airline;
        this.NumberOfCrew = numberOfCrew;
        this.Captain = captain;
    }
}