int t = int.Parse(Console.ReadLine());
for(int i = 0; i < t; i++){
    int n = int.Parse(Console.ReadLine());
    System.Console.WriteLine(n >= 1900 ? "Division 1" : n >= 1600 ? "Division 2" : n >= 1400 ? "Division 3" : "Division 4");
}