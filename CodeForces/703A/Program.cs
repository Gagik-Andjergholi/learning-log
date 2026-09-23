int t = int.Parse(Console.ReadLine());
string s;
int[] cnt = new int[2];
while(t-- > 0)
{
    s = Console.ReadLine();
    if(s[0] == s[2])
        continue;
    cnt[s[0] > s[2] ? 0 : 1]++;
}
if(cnt[0] == cnt[1])
{
    System.Console.WriteLine("Friendship is magic!^^");
}else if(cnt[0] > cnt[1])
{
    System.Console.WriteLine("Mishka");
}
else
{
    System.Console.WriteLine("Chris");
}
