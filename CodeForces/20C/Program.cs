PriorityQueue<int, long> minHeap = new PriorityQueue<int, long>();
var (n, m) = Console.ReadLine().Split(' ').Select(int.Parse).ToArray() switch {[var x, var y] => (x, y)};
List<Tuple<int, int>>[] adj = new List<Tuple<int, int>>[n];
long[] dis = new long[n];
int[] prev = new int[n];

for(int i = 0; i < n; i++)
{
    adj[i] = new List<Tuple<int, int>> {};
    dis[i] = long.MaxValue;
}
dis[0] = 0;
minHeap.Enqueue(0, 0);

for(int i = 0; i < m; i++)
{
    var (u, v, w) = Console.ReadLine().Split(' ').Select(int.Parse).ToArray() switch {[var x, var y, var z] => (x, y, z)};
    u--;v--;
    adj[u].Add(Tuple.Create(v, w));
    adj[v].Add(Tuple.Create(u, w));
}

while(minHeap.Count > 0)
{
    minHeap.TryDequeue(out int u, out long w);
    if(w > dis[u])
        continue;
    foreach(var x in adj[u])
    {
        if(dis[x.Item1] > w + x.Item2)
        {
            dis[x.Item1] = w + x.Item2;
            minHeap.Enqueue(x.Item1, dis[x.Item1]);
            prev[x.Item1] = u;
        }
    }
}
List<int> p = new List<int> {};
void path(int x)
{
    if(x == 0)
    {
        p.Add(1);
        return;
    }
    path(prev[x]);
    p.Add(x + 1);
}
path(n - 1);
System.Console.WriteLine(dis[n - 1] == long.MaxValue ?  -1 : String.Join(' ', p));