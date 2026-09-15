int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int x = 7 - Math.Max(a[0], a[1]);
int six = 6;
if(x % 2 == six % 2)
{
    x /= 2;
    six /= 2;
}
if(x % 3 == six % 3)
{
    x /= 3;
    six /= 3;
}
System.Console.WriteLine($"{x}/{six}");