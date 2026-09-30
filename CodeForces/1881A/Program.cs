using System.Runtime.InteropServices.Marshalling;

int t = int.Parse(Console.ReadLine());
string s, x;
bool con(string p)
{
    bool b;
    for(int i = 0; i <= x.Length - p.Length; i++)
    {
        b = true;
        for(int j = i; j < p.Length + i; j++)
        {
            if(x[j] != p[j - i])
            {
                b = false;
                break;
            }
        }
        if (b)
        {
            return true;
        }
    }
    return false;
}
while(t-- > 0)
{
    int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int n = input[0], m = input[1];
    x = Console.ReadLine();
    s = Console.ReadLine();
    int ans = 0;
    while(x.Length < s.Length)
    {
        ans++;
        x += x;
    }
    if (con(s))
    {
        System.Console.WriteLine(ans);
        continue;
    }
    x += x;
    ans++;
    if (con(s))
    {
        System.Console.WriteLine(ans);
        continue;
    }
    System.Console.WriteLine(-1);
}