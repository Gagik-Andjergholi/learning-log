int t = int.Parse(Console.ReadLine());
string s;
while(t-- > 0)
{
    s = Console.ReadLine();
    if(s.Length % 2 == 1)
    {
        Console.WriteLine("NO");
        continue;
    }
    Console.WriteLine(s.Substring(0, s.Length / 2) == s.Substring((s.Length + 1) / 2, s.Length / 2) ? "YES" : "NO");
}