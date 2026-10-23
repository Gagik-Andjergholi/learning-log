int t = int.Parse(Console.ReadLine());
int n;
bool b;
while(t-- > 0){
    n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Array.Sort(a);
    b = true;
    for(int i = 1; i < n; i++)
    {
        if(a[i] == a[i - 1])
        {
            b = false;
            break;
        }
    }
    System.Console.WriteLine(b ? "YES" : "NO");
}