namespace ConsoleApp.CustomException;

public class SizeException : Exception
{
    public SizeException(string message) : base(message)
    {
    }
}