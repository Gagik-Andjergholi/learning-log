int t = int.Parse(Console.ReadLine());
string s;
int n, ans, cnt;
bool b;
while(t-- > 0)
{
    n = int.Parse(Console.ReadLine());
    s = Console.ReadLine();
    cnt = 0; ans = 0; b = false;
    for(int i = 0; i < n; i++)
    {
        if(s[i] == '#' && cnt >= 1)
        {
            ans += cnt >= 2 ? 2 : 1;
            cnt = 0;
            continue;
        }else if(s[i] == '#')
        {
            continue;
        }
        cnt++;
        if(cnt >= 3)
        {
            ans = 2;
            cnt = 0;
            break;
        }
    }
    if(cnt != 0)
    {
        ans += cnt >= 2 ? 2 : 1;
    }
    System.Console.WriteLine(ans);
}