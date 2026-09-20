int[] trash = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int ans = 0;
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Array.Sort(a);
for(int i = 0; i < trash[1]; i++)
{
    if(a[i] >= 0)
    {
        break;
    }
    ans += a[i];
}
System.Console.WriteLine(-1 * ans);