using System.Runtime.CompilerServices;

int t = int.Parse(Console.ReadLine());
string s;
int ans;
while(t-- > 0){
    ans = 0;
    for(int i = 0; i < 10; i++)
    {
        s = Console.ReadLine();
        for(int j = 0; j < 10; j++)
        {
            if(s[j] == 'X')
            {
                ans += calc(i, j);
            }
        }
    }
    System.Console.WriteLine(ans);
}

int calc(int x, int y)
{
    return Math.Min(Math.Min(x + 1, 10 - x), Math.Min(y + 1, 10 - y));
}