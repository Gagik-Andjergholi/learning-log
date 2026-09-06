int t = int.Parse(Console.ReadLine());
string c = "codeforces";
while(t-- > 0)
{
    string s = Console.ReadLine();
    if (c.Contains(s))
    {
        System.Console.WriteLine("YES");
    }
    else
    {
        System.Console.WriteLine("NO");
    }
}