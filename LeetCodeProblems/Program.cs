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
        var problem = new P349();
        int[] nums1 = [1, 2, 2, 1], nums2 = [2,2];

        var result = problem.Intersection(nums1, nums2);

        Console.WriteLine(string.Join(",", result));
    }
}

