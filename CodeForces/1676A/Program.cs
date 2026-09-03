int t = int.Parse(Console.ReadLine());
while(t-- > 0)
{
    string s = Console.ReadLine();
    if((int)s[0] + (int)s[1] + (int)s[2] == (int)s[3] + (int)s[4] + (int)s[5])
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}