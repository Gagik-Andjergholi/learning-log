namespace ConsoleApp.CustomException;

public class PressureToleranceException : Exception
{
    public PressureToleranceException(string message) : base(message)
    {
    }
}