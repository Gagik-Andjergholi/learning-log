int t = int.Parse(Console.ReadLine());
while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int min = 0;
    for(int i = 1; i < n; i++)
    {
        if(a[min] > a[i])
        {
            min = i;
        }
    }
    a[min]++;
    min = 1;
    for(int i = 0; i < n; i++)
    {
        min *= a[i];
    }
    System.Console.WriteLine(min);
}