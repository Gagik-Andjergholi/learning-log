int n = int.Parse(Console.ReadLine());
if(n >= 0)
{
    Console.WriteLine(n);
}
else
{
    n = -n;
    Console.WriteLine(-(Math.Min(n / 100 * 10 + n % 10, n / 10)));
}