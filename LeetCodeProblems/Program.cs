using LeetCodeProblems.Problems.P872;
using LeetCodeProblems.Trees;

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
        int?[] a = [1, 2, 3];
        int?[] b = [1, 3, 2];

        var at = a.BuildTree();
        var bt = b.BuildTree();

        at.Print();
        bt.Print();

        var problem = new P872();
        var result = problem.LeafSimilar(at, bt);
        Console.WriteLine(result);
    }
}

