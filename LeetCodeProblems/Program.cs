using LeetCodeProblems.Models;
using LeetCodeProblems.Problems.P21;
using LeetCodeProblems.Problems.P349;
using LeetCodeProblems.Problems.P83;

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
        var a = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));

        var problem = new P83();
        var result = problem.DeleteDuplicates(a);
        _ = result;
    }
}

