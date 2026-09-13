int t = int.Parse(Console.ReadLine());
List<int> a = new List<int> {};
for(int i = 1; i < 5000; i++)
{
    if(i % 3 == 0 || i % 10 == 3)
    {
        continue;
    }
    a.Add(i);
}
int n;
while(t-- > 0)
{
    n = int.Parse(Console.ReadLine());
    System.Console.WriteLine(a[n - 1]);
}