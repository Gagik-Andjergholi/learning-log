namespace ConsoleApp;

public class Examiner
{
    public List<string> CheckProductList(List<Product> products)
    {
        List<string> errors = new List<string> {};
        foreach(var product in products)
        {
            try
            {
                CheckProduct(product);
            }
            catch (Exception ex)
            {
                errors.Add($"{product.Id}-{ex.Message}");
            }
        }
        return errors;
    }

    private void CheckProduct(Product p)
    {
        if (p.Size != 70)
        {
            throw new CustomException.SizeException("SizeException");
        }
        if(p.PressureTolerance < 1000)
        {
            throw new CustomException.PressureToleranceException("PressureToleranceException");
        }
        if(p.ColorTransparency < 235 || p.ColorTransparency > 245)
        {
            throw new CustomException.ColorTransparencyException("ColorTransparencyException");
        }
    }
}