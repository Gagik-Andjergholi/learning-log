int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int n = input[0], x = input[1];
    int temp = x;
    long answer = 0;
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    List<int> primes = new List<int>();
    for (int p = 2; (long)p * p <= temp; p++)
    {
        if (temp % p != 0) continue;
        primes.Add(p);
        while (temp % p == 0)
            temp /= p;
    }
    if (temp > 1)
        primes.Add(temp);
    long sum;
    foreach (var p in primes)
    {
        sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (a[i] % p == 0)
                sum += a[i];
        }
        answer = Math.Max(answer, sum);
    }
    System.Console.WriteLine(answer);
}