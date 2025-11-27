using LeetCodeProblems.Problems.P226;
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
        int?[] root = [4, 2, 7, 1, 3, 6, 9];

        TreeFunctions.BuildTree(root).Print();

        var p = new P226();

        p.InvertTree(TreeFunctions.BuildTree(root)).Print();
    }
}

