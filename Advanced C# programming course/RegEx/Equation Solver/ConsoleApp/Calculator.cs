using System.Text.RegularExpressions;

namespace ConsoleApp;

public class Calculator
{
    public static string Solve(string equation)
    {
        equation = Regex.Replace(equation, @"\+?=?", "");
        string[] s = Regex.Split(equation, @"\s+");
        int a, b, c, ans;
        string x;
        if(Regex.IsMatch(s[2], @"#")) // if C has the #
        {
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            ans = a + b;
            x = Regex.Replace(s[2], "#", @"\d*");
            x = '^' + x + '$';
            if(!Regex.IsMatch(ans.ToString(), x))
            {
                return "-1";
            }
            s[2] = ans.ToString();
        }else if(Regex.IsMatch(s[0], @"#")) // if A has the #
        {
            b = int.Parse(s[1]);
            c = int.Parse(s[2]);
            ans = c - b;
            x = Regex.Replace(s[0], "#", @"\d*");
            x = '^' + x + '$';
            if(!Regex.IsMatch(ans.ToString(), x))
            {
                return "-1";
            }
            s[0] = ans.ToString();
        }else // if B has the #
        {
            a = int.Parse(s[0]);
            c = int.Parse(s[2]);
            ans = c - a;
            x = Regex.Replace(s[1], "#", @"\d*");
            x = '^' + x + '$';
            if(!Regex.IsMatch(ans.ToString(), x))
            {
                return "-1";
            }
            s[1] = ans.ToString();
        }   
        equation = s[0] + " + " + s[1] + " = " + s[2];
        return equation;
    }
}