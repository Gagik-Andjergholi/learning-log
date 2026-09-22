using System.Security.Cryptography;

int t = int.Parse(Console.ReadLine());
int n, ans, z, o;
int[] cnt = new int[2];
while(t-- > 0)
{
    n = int.Parse(Console.ReadLine());
    (ans, cnt[0], cnt[1], z, o) = (n, 0, 0, 0, 0);
    string s = Console.ReadLine();
    if(s.Contains('1') == false || s.Contains('0') == false)
    {
        Console.WriteLine(0);
        continue;
    }
    for(int i = 0; i < n; i++)
    {
        cnt[s[i] - '0']++;
    }
    if(s[0] == '1')
    {
        System.Console.WriteLine(cnt[0]);
        continue;
    }

    for(int i = 0; i < n; i++)
    {
        if(s[i] == '0')
        {
            z++;
            cnt[0]--;
        }
        else
        {
            o++;
            cnt[1]--;
        }

        ans = Math.Min(ans, o + cnt[0]);
    }
    System.Console.WriteLine(ans);
}
