int t = int.Parse(Console.ReadLine());
int n, sum, one;
while(t-- > 0){
    sum = 0; one = 0;
    n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    for(int i = 0; i < n; i++)
    {
        sum += a[i];
        one += a[i] % 2;
    }
    if(sum % 4 == 0 || (sum % 4 == 2 && one >= 2))
    {
        System.Console.WriteLine("YES");
        continue;
    }
    System.Console.WriteLine("NO");
}