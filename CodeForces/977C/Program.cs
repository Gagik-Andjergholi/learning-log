int[] inp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int k = inp[1];
Array.Sort(a);
if(k == a.Length)
{
    System.Console.WriteLine(a[a.Length - 1]);
}else if(k == 0)
{
    System.Console.WriteLine(a[0] == 1 ? -1 : 1);
}
else if(a[k] == a[k - 1])
{
    System.Console.WriteLine(-1);
}else
{
    System.Console.WriteLine(a[k - 1]);
}