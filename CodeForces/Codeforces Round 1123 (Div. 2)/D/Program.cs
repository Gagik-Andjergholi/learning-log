using System.Runtime.InteropServices;

int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n= int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int[] ind = new int[200050];
    for(int i = 0; i < n; i++)
    {
        ind[a[i]] = i;
    }
    bool b = true;
    int l = 0, r = n - 1;
    Array.Sort(a);
    for(int i = 0; i < n; i++)
    {
        if(ind[a[i]] % 2 == l % 2)
        {
            l++;
        }else if(ind[a[i]] % 2 == r % 2)
        {
            r--;
        }
        else
        {
            b = false;
        }
    }
    System.Console.WriteLine(b? "YES" : "NO");
}