namespace ConsoleApp;

public static class ListExtensions
{
    // TODO: implement GetAverageScore function here.
    public static double GetAverageScore(this List<int> L)
    {
        int avg = 0;
        for(int i = 0; i < L.Count; i++)
        {
            avg += L[i];
        }
        return (double)avg / L.Count;
    }
    
    // TODO: implement GetHighestScore function here.
    public static int GetHighestScore(this List<int> L)
    {
        int max = L[0];
        for(int i = 0; i < L.Count; i++)
        {
            max = Math.Max(max, L[i]);
        }
        return max;
    }
    
    // TODO: implement DidAllStudentsPass function here.
    public static bool DidAllStudentsPass(this List<int> L)
    {
        for(int i = 0; i < L.Count; i++)
        {
            if(L[i] < 70)
                return false;
        }
        return true;
    }
}