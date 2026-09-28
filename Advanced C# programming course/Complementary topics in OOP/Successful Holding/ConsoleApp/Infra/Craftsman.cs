namespace ConsoleApp.Infra;

public abstract class Craftsman : ICraft
{
    public abstract string CraftsmanSkill();
    public abstract void CreateItem();
    public abstract void DisplayItem();
    public abstract void SellItem();
}