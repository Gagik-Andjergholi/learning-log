int t = int.Parse(Console.ReadLine());
int n, k, ans, len;
while(t-- > 0){

    int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    (n, k) = (input[0], input[1]);
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Array.Sort(a);
    len = 1;
    ans = 0;
    for(int i = 1; i < n; i++)
    {
        if(a[i] - a[i-1] <= k){
            len++;
        }else{
            ans = Math.Max(ans, len);
            len = 1; 
        }
    }
    Console.WriteLine(n - Math.Max(ans, len));
}