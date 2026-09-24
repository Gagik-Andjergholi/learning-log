using System.Text.RegularExpressions;

namespace ConsoleApp;

public static class ValidatorHelpers
{
    public static bool ValidateEmail(string email)
    {
        string pattern = @"^[\w\.]+@[a-zA-z0-9]+\.[A-z]{3}$";
        return Regex.IsMatch(email, pattern);
    }

    public static bool ValidatePhone(string phone)
    {
        string pattern = @"^(0|\+98|0098)9\d{9}$";
        return Regex.IsMatch(phone, pattern);
    }
}
