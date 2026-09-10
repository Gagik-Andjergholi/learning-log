int n = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
List<int> O = new List<int> {};
List<int> I = new List<int> {};
List<int> Z = new List<int> {};
for(int i = 0; i < n ; i++)
{
    switch(a[i] % 3)
    {
        case 0:
            O.Add(i + 1);
            break;
        case 1:
            I.Add(i + 1);
            break;
        case 2:
            Z.Add(i + 1);
            break;
    }
}
int ans = Math.Min(O.Count, Math.Min(I.Count, Z.Count));
System.Console.WriteLine(ans);
if(ans == 0)
    return 0;
for(int i = 0; i < ans; i++)
{
    System.Console.WriteLine(O[i] + " " + I[i] + " " + Z[i]);
}
return 0;