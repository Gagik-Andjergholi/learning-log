using System.Text.RegularExpressions;
namespace ConsoleApp;

public static class RealNumberHelper
{
    public static List<string> Check(List<string> numbers)
    {
        List<string> ans = new List<string> {};
        string pattern = @"^\s*(\+|-)?\d+(\.\d+)?((E|e)(\+|-)?\d+)?\s*$";
        for(int i = 0; i < numbers.Count; i++)
        {
            ans.Add(Regex.IsMatch(numbers[i], pattern) == true ? "LEGAL" : "ILLEGAL");
        }
        return ans;
    }
}