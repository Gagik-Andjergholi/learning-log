int n = int.Parse(Console.ReadLine());
string s = Console.ReadLine();
s = s.ToLower();
char[] c = s.ToCharArray();
c = c.Distinct().ToArray();
if(c.Length == 26)
    System.Console.WriteLine("Yes");
else
    System.Console.WriteLine("NO");