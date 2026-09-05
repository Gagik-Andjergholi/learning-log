int t = int.Parse(Console.ReadLine());
int n, k;
int[] cnt = new int[105];
int[] a = new int[105];
while(t-- > 0){
    Array.Clear(cnt, 0, cnt.Length);
    string[] input = Console.ReadLine().Split(' ');
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);
    a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    for(int i = 0; i < n; i++){
        cnt[a[i]]++;
    }
    if(cnt[k] > 0){
        Console.WriteLine("YES");
    } else {
        Console.WriteLine("NO");
    }
}