string s = Console.ReadLine();
int abf = s.IndexOf("AB"), bal = s.LastIndexOf("BA");
int abl = s.LastIndexOf("AB"), baf = s.IndexOf("BA");
System.Console.WriteLine((abf != -1 && baf != -1 && 
    (Math.Abs(abf - bal) != 1 || Math.Abs(abl - baf) != 1) ? "YES" : "NO"));