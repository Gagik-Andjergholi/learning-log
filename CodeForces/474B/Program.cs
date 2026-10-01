int n = int.Parse(Console.ReadLine());
long[] a = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
int m = int.Parse(Console.ReadLine());
long[] q = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
for(int i = 1; i < n; i++){
    a[i] = a[i - 1] + a[i];
}
int bs(long x){
    int l = 0, r = n, mid;
    while(l < r){
        mid = (l + r) / 2;
        if(a[mid] > x){
            r = mid;
        }else if(x == a[mid]){
            return mid + 1;
        }
        else{
            l = mid + 1;
        }
    }
    return l == n ? l : l + 1;
}
for(int i = 0; i < m; i++){
    Console.WriteLine(bs(q[i]));
}