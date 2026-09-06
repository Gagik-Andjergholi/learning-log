int t = int.Parse(Console.ReadLine());
int n, k;
while(t-- > 0){
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    if(a[0] == a[1])
    {
        System.Console.WriteLine(a[2]);
    }
    else
    {
        if(a[0] == a[2])
        {
            System.Console.WriteLine(a[1]);
            continue;
        }
        else
        {
            System.Console.WriteLine(a[0]);
            continue;
        }
    }
}