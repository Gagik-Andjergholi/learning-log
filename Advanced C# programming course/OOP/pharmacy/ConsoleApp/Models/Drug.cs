namespace ConsoleApp.Models;

public class Drug
{
    public string Name;
    public int Amount;
    public int Price;

    public Drug(string name, int amount, int price)
    {
        this.Name = name;
        this.Amount = amount;
        this.Price = price;
    }
}