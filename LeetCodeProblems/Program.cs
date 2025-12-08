using LeetCodeProblems.Problems.P1370;

namespace LeetCodeProblems;

internal class Program
{
    static void Main(string[] args)
    {
        var prog = new Runner();
        prog.Run();
    }
}

public class Runner
{
    public void Run()
    {
        var p = new P1370();

        var res = p.SortString("rat");
        Console.WriteLine(res);
    }
}

