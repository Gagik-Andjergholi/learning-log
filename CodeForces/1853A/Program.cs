int t = int.Parse(Console.ReadLine());
int n;
while(t-- > 0){
    n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int ans = a[1] - a[0];
    for(int i = 1; i < n - 1; i++)
    {
        ans = Math.Min(ans, a[i + 1] - a[i]);
    }
    if(ans < 0)
    {
        System.Console.WriteLine(0);
    }else if(ans == 0)
    {
        System.Console.WriteLine(1);
    }
    else
    {
        System.Console.WriteLine(ans / 2 + 1);
    }

}