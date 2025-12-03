using LeetCodeProblems.Problems.P1624;

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
        string s = "abqwert";

        var problem = new P1624();
        var result = problem.MaxLengthBetweenEqualCharacters(s);
        Console.WriteLine(result);
    }
}

