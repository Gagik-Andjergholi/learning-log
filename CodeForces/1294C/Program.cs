using System.Runtime.CompilerServices;

int t = int.Parse(Console.ReadLine());
int n, k, copy;
int[] a = new int[3];
while(t-- > 0)
{
    k = 0;
    Array.Fill(a, 0);
    n = int.Parse(Console.ReadLine());
    copy = n;
    for(int i = 2; i * i <= copy; i++)
    {
        if(n % i == 0)
        {
            if(k == 3)
                break;
            a[k] = i;
            n /= i;
            k++;
        }
    }
    if(k <= 1)
    {
        System.Console.WriteLine("NO");
        continue;
    }
    a[2] = copy / (a[0] * a[1]);
    if(a[2] == a[0] || a[1] == a[2])
    {
        System.Console.WriteLine("NO");
        continue;
    }
    System.Console.WriteLine("YES\n" + a[0] + " " + a[1] + " " + a[2]);

}