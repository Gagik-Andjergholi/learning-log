int t = int.Parse(Console.ReadLine());
int n, k;
while(t-- > 0){
    n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    if(a[0] == a[1])
    {
        k = a[0];
    }
    else
    {
        if(a[0] == a[2])
        {
            System.Console.WriteLine(2);
            continue;
        }
        else
        {
            System.Console.WriteLine(1);
            continue;
        }
    }
    for(int i = 2; i < n; i++)
    {
        if(a[i] != k)
        {
            System.Console.WriteLine(i + 1);
            break;
        }
    }
}