using LeetCodeProblems.Problems._108._Convert_Sorted_Array_to_Binary_Search_Tree;

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
        var p = new P108();

        int[] a = [-10, -3, 0, 5, 9];

        p.SortedArrayToBST(a);
    }
}

