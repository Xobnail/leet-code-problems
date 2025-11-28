using LeetCodeProblems.Problems.P100;
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
        var problem = new P100();

        int?[] p = [10, 5, 15];
        int?[] q = [10, 5, null, null, 15];

        var pTree = p.BuildTree();
        var qTree = q.BuildTree();

        pTree.Print();
        qTree.Print();
        Console.WriteLine(problem.IsSameTree(pTree, qTree));
    }
}

