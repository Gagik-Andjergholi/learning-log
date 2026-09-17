int n = int.Parse(Console.ReadLine());
string[] s = new string[n];
for(int i = 0; i < n; i++)
{
    s[i] = Console.ReadLine();
}
Array.Sort(s);
System.Console.WriteLine(s[n / 2]);