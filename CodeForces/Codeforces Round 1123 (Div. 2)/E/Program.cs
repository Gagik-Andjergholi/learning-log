int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int n = input[0], q = input[1];
    char[] s = Console.ReadLine().ToCharArray();

    long z = 0, sum = 0;
    for (int i = 0; i < n; i++)
    {
        if (s[i] == '0')
            z++;

        if (i + 1 < n && s[i] != s[i + 1])
            sum += (long)(i + 1) * (n - i - 1);
    }

    Console.Write((sum + z * (n - z)) / 2);
    while (q-- > 0)
    {
        int p = int.Parse(Console.ReadLine()) - 1;
        if (p > 0)
        {
            long count = (long)p * (n - p);
            sum += s[p] == s[p - 1] ? count : -count;
        }


        if (p + 1 < n)
        {
            long count = (long)(p + 1) * (n - p - 1);
            sum += s[p] == s[p + 1] ? count : -count;
        }

        if (s[p] == '0')
        {
            s[p] = '1';z--;
        }
        else
        {
            s[p] = '0';
            z++;
        }
        Console.Write(" " + (sum + z * (n - z)) / 2);
    }
    Console.WriteLine();
}