namespace LeetCodeProblems.Problems._412._Fizz_Buzz;

/// <summary>
/// 412. Fizz Buzz
/// </summary>
internal class P412
{
    public IList<string> FizzBuzz(int n)
    {
        string[] result = new string[n];

        for (int i = 1;  i <= n; i++)
        {
            if (i % 3 == 0 && i % 5  == 0)
            {
                result[i - 1] = "FizzBuzz";
                continue;
            }

            if (i % 3 == 0)
            {
                result[i - 1] = "Fizz";
                continue;
            }

            if (i % 5 == 0)
            {
                result[i - 1] = "Buzz";
                continue;
            }

            result[i - 1] = i.ToString();
        }

        return result;
    }
}
