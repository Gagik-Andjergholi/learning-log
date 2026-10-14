int t = int.Parse(Console.ReadLine());
long n, k, x;
while(t-- > 0)
{
    long[] input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
    (n, k, x) = (input[0], input[1], input[2]);
    if(x >= k * (k + 1) / 2 && x <= k * (2 * n - k + 1) / 2)
    {
        System.Console.WriteLine("YES");
    }
    else
    {
        System.Console.WriteLine("NO");
        
    }
}