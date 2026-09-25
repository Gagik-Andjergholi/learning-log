namespace ConsoleApp.Models;

public class B707 : Airplane
{
    public B707(
        string name,
        decimal price,
        int numberOfSeats,
        int maxspeed,
        string fuel,
        int numberOfFins,
        int numberOfWheels,
        string steeringWheel,
        string airline,
        int numberOfCrew,
        string captain)
            : base(
                name,
                price,
                numberOfSeats,
                maxspeed,
                fuel,
                numberOfFins,
                numberOfWheels,
                steeringWheel,
                airline,
                numberOfCrew,
                captain)
    {
    }
}