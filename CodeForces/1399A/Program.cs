int t = int.Parse(Console.ReadLine());
int n;
while(t-- > 0){
    string s = "YES";
    n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Array.Sort(a);
    for(int i = 0; i < n - 1; i++)
    {
        if(a[i + 1] - a[i] > 1)
        {
            s = "NO";
        }
    }
    System.Console.WriteLine(s);
}