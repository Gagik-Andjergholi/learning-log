bool[] c = new bool[1000050];
int n = 1000050;
for(int i = 2; i < n; i++)
{
    if (!c[i])
    {
        for(int j = 2 * i; j < n; j += i)
        {
            c[j] = true;
        }
    }
}
n = int.Parse(Console.ReadLine());
for(int i = 2; i < n; i++)
{
    if(c[i] && c[n - i])
    {
        System.Console.WriteLine(i + " " + (n - i));
        break;
    }
}