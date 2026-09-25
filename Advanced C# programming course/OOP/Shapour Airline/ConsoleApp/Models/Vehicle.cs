namespace ConsoleApp.Models;

public class Vehicle
{
    public string Name;
    public decimal Price;
    public int NumberOfSeats;
    public int MaxSpeed;

    public Vehicle(string name, decimal price, int numberOfSeats, int maxspeed)
    {
        this.Name = name;
        this.Price = price;
        this.NumberOfSeats = numberOfSeats;
        this.MaxSpeed = maxspeed;
    }

}