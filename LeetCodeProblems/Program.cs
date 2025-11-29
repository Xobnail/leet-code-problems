using LeetCodeProblems.Models;
using LeetCodeProblems.Problems.P21;
using LeetCodeProblems.Problems.P349;

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
        var a = new ListNode(-2, new ListNode(5));
        var b = new ListNode(-9, new ListNode(-6, new ListNode(-3, new ListNode(-1, new ListNode(1, new ListNode(6))))));

        var problem = new P21();
        var result = problem.MergeTwoLists(a, b);
        _ = result;
    }
}

