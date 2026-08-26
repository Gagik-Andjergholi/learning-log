int n = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int q = int.Parse(Console.ReadLine());
Array.Sort(a);

int l, r, mid;

int bs(int x)
{
    l = 0; r = n;
    while(l < r)
    {
        mid  = (r + l) / 2;
        if(a[mid] > x)
        {
            r = mid;
        }else
        {
            l = mid + 1;
        }
    }
    return l;
}

for (int i  = 0; i < q; i++)
{
    Console.WriteLine(bs(int.Parse(Console.ReadLine())));
}