int t = int.Parse(Console.ReadLine());
string s;
while(t-- > 0)
{
    s = Console.ReadLine();
    if(s[0] == 'a' || s[1] == 'b' || s[2] == 'c')
    {
        System.Console.WriteLine("YES");
    }
    else
    {
        System.Console.WriteLine("NO");
    }
}