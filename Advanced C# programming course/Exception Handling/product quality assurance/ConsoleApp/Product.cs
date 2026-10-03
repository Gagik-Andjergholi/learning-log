namespace ConsoleApp;

public class Product
{
   //Id، Size، PressureTolerance و 
   public int Id { get; set; }
   public int Size { get; set; }
   public int PressureTolerance { get; set; }
   public int ColorTransparency {get; set;}

   public Product(int id, int size, int pressureTolerance, int colorTransparency)
   {
      Id = id;
      Size = size;
      PressureTolerance = pressureTolerance;
      ColorTransparency = colorTransparency;
   }
}