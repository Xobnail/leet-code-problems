namespace LeetCodeProblems.Problems.P509;

/// <summary>
/// 509. Fibonacci Number
/// </summary>
internal class P509
{
    /// <summary>
    /// С помощью цикла.
    /// </summary>
    public int Fib1(int n)
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

    /// <summary>
    /// С помощью рекурсии.
    /// </summary>
    public int Fib(int n)
    {
        if (n < 2)
        {
            return n;
        }

        return Fib(n - 1) + Fib(n - 2);
    }
}
