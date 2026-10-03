int t = int.Parse(Console.ReadLine());
int n, k, o;
int[] cnt = new int[26];
string s;
while(t-- > 0){
    int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    (n, k) = (input[0], input[1]);
    s = Console.ReadLine();
    Array.Fill(cnt, 0);
    for(int i = 0; i < n; i++){
        cnt[s[i] - 'a']++;
    }
    o = 0;
    for(int i = 0; i < 26; i++){
        o += cnt[i] % 2;
    }
    if(o > k + 1){
        Console.WriteLine("NO");
        continue;
    }
    Console.WriteLine("YES");
}