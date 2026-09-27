int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
string s = Console.ReadLine();
int ans = 0;
for(int i = 0; i < s.Length; i++)
{
    ans += a[s[i] - '1'];
}
System.Console.WriteLine(ans);