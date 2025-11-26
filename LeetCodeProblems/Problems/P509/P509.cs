namespace LeetCodeProblems.Problems.P509;

/// <summary>
/// 509. Fibonacci Number
/// </summary>
internal class P509
{
    public int Fib(int n)
    {
        if (n < 2)
        {
            return n;
        }

        int result = 0;
        int prevPrev = 0;
        int prev = 1;

        for (int i = 2; i <= n; i++)
        {
            result = prevPrev + prev;
            prevPrev = prev;
            prev = result;
        }

        return result;
    }
}
