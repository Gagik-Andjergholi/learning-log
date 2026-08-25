int n = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int p = a[0], q = b[0];
bool[] c = new bool[n];
bool[] d = new bool[n];
if(p + q < n)
{
    Console.WriteLine("Oh, my keyboard!");
    return 0;
}
 
for(int i = 1; i <= p; i++)
{
    c[a[i] - 1] = true;
}
for(int i = 1; i <= q; i++)
{
    d[b[i] - 1] = true;
}
int uniqc = 0, uniqd = 0;
bool[] uniq = new bool[n];
for(int i = 0; i < n; i++)
{
    if(c[i] ^ d[i] == true)
    {
        uniq[i] = true;
        if(c[i])
        {
            uniqc++;
        }
        else
        {
            uniqd++;
        }
    }
    if(!(c[i] || d[i]))
    {
      Console.WriteLine("Oh, my keyboard!");
      return 0;    
    }
}


int k = n - (uniqc + uniqd), x = p - uniqc, y = q - uniqd;
if(x + y < k)
{
    Console.WriteLine("Oh, my keyboard!");
    return 0;
}
Console.WriteLine("I become the guy.");
return 0;