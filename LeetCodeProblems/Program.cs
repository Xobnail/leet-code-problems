using LeetCodeProblems.Models;
using LeetCodeProblems.Problems.P21;
using LeetCodeProblems.Problems.P349;
using LeetCodeProblems.Problems.P83;
using LeetCodeProblems.Problems.P897;
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
        int?[] a = [5, 3, 6, 2, 4, null, 8, 1, null, null, null, 7, 9];

        var ba = a.BuildTree();
        ba.Print();

        var problem = new P897();
        var result = problem.IncreasingBST(ba);
        result.Print();
    }
}

