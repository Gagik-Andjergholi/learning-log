int t = int.Parse(Console.ReadLine());
while(t-- > 0)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    if(a[0] < a[1] && a[1] < a[2])
    {
        System.Console.WriteLine("STAIR");
        continue;
    }
    if(a[0] < a[1] && a[1] > a[2])
    {
        System.Console.WriteLine("PEAK");
        continue;
    }
    System.Console.WriteLine("NONE");
}