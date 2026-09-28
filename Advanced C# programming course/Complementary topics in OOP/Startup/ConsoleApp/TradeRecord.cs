using System.Numerics;

namespace ConsoleApp;

public class TradeRecord
{
    public int Quantity { get; init; }
    public decimal PricePerUnit { get; init; }
    public readonly decimal totalValue;
    public TradeRecord(int quantity, decimal pricePerUnit)
    {
        Quantity = quantity;
        PricePerUnit = pricePerUnit;
        totalValue = quantity * pricePerUnit;
    }
    
    public static TradeRecord operator + (TradeRecord T1, TradeRecord T2)
    {
        return new TradeRecord(T1.Quantity + T2.Quantity, (T1.PricePerUnit + T2.PricePerUnit) / 2);
    }
    public static TradeRecord operator - (TradeRecord T1, TradeRecord T2)
    {
        return new TradeRecord(Math.Max(0, T1.Quantity - T2.Quantity), T1.PricePerUnit);
    }
    public static bool operator == (TradeRecord T1, TradeRecord T2)
    {
        return T1.totalValue == T2.totalValue;
    }
    public static bool operator != (TradeRecord T1, TradeRecord T2)
    {
        return T1.totalValue != T2.totalValue;
    }
    public override string ToString()
    {
        return $"Quantity: {this.Quantity}, PricePerUnit: {this.PricePerUnit}, TotalValue: {this.totalValue}";
    }
}