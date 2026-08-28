int n = int.Parse(Console.ReadLine());
Dictionary<string, int> dict = new Dictionary<string, int>();
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    if (dict.ContainsKey(s))
    {
        dict[s]++;
        Console.WriteLine(s + dict[s]);
    }
    else
    {
        Console.WriteLine("OK");
        dict[s] = 0;
    }
}