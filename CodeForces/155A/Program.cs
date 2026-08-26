int n = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int cnt = 0,max = a[0], min = a[0];
for (int i = 1; i < n; i++)
{
    if(a[i] > max)
    {
        max = a[i];
        cnt++;
    }
    else if(a[i] < min)
    {
        min = a[i];
        cnt++;
    }
}
Console.WriteLine(cnt);